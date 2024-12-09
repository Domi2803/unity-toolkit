using UnityEngine;

namespace DomesUnityToolkit.ReflectionEventRaiser
{
    [AddComponentMenu("Events/Reflection Event Raiser/Color Event Raiser")]
    #if ODIN_INSPECTOR
    [Sirenix.OdinInspector.HideMonoScript]
    #endif
    public class ColorReflectionEventRaiser : ReflectionEventRaiser<Color>
    { }
}