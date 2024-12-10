using UnityEngine;
using UnityEngine.Events;

namespace DomesUnityToolkit.ReflectionEventRaiser
{
    [AddComponentMenu("Events/Reflection Event Raiser/Bool Event Raiser")]
#if ODIN_INSPECTOR
    [Sirenix.OdinInspector.HideMonoScript]
#endif
    public class BoolReflectionEventRaiser : ReflectionEventRaiser<bool>
    {
        public UnityEvent onTrue;
        public UnityEvent onFalse;

        internal override void RaiseEvent(bool value)
        {
            base.RaiseEvent(value);

            if (value)
            {
                onTrue.Invoke();
            }
            else
            {
                onFalse.Invoke();
            }
        }
    }
}