using UnityEngine;

namespace DomesUnityToolkit.Extensions
{
    public static class FloatExtensions
    {
        public static void Clamp(this ref float value, float min, float max)
        {
            value = Mathf.Clamp(value, min, max);
        }

        public static float Clamped(this float value, float min, float max)
        {
            return Mathf.Clamp(value, min, max);
        }

        public static void Clamp01(this ref float value)
        {
            value = Mathf.Clamp01(value);
        }

        public static float Clamped01(this float value)
        {
            return Mathf.Clamp01(value);
        }
    }
}