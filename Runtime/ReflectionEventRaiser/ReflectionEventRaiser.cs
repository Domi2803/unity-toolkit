using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

namespace DomesUnityToolkit.ReflectionEventRaiser
{
    public class ReflectionEventRaiser<T> : MonoBehaviour
    {
        private T _previousValue;

        public UnityEngine.Object target;

        public UnityEvent onValueChanged;

        #if ODIN_INSPECTOR
        [Sirenix.OdinInspector.ValueDropdown("GetValidValueNames")]
        #endif
        public string valueName;

        private void Start()
        {
            Evaluate(true);
        }

        private void Update()
        {
            Evaluate();
        }

        private void Evaluate(bool ignorePreviousValue = false)
        {
            if (!target)
            {
                return;
            }

            // Get the value of the field or property with the given name on the target object. If the value is not found, default to default(T).
            var value = (T)((target.GetType().GetField(valueName)?.GetValue(target) ??
                             target.GetType().GetProperty(valueName)?.GetValue(target)) ?? default(T));

            if (!ignorePreviousValue && EqualityComparer<T>.Default.Equals(value, _previousValue))
            {
                return;
            }

            _previousValue = value;

            onValueChanged.Invoke();
        }

        private string[] GetValidValueNames()
        {
            if (target == null) return Array.Empty<string>();

            var fields = target.GetType().GetFields().Where(f => f.FieldType == typeof(T)).Select(f => f.Name);
            var properties = target.GetType().GetProperties().Where(p => p.PropertyType == typeof(T)).Select(p => p.Name);

            return fields.Concat(properties).ToArray();
        }
    }
}