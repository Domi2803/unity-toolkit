using UnityEngine;

namespace DomesUnityToolkit.ReflectionEventRaiser
{
    [AddComponentMenu("Events/Reflection Event Raiser/Bool Event Raiser")]
    #if ODIN_INSPECTOR
    [Sirenix.OdinInspector.HideMonoScript]
    #endif
    public class BoolReflectionEventRaiser : ReflectionEventRaiser<bool>
    { }
}