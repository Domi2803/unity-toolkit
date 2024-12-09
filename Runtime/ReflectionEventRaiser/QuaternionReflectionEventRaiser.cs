using UnityEngine;

namespace DomesUnityToolkit.ReflectionEventRaiser
{
    [AddComponentMenu("Events/Reflection Event Raiser/Quaternion Event Raiser")]
    #if ODIN_INSPECTOR
    [Sirenix.OdinInspector.HideMonoScript]
    #endif
    public class QuaternionReflectionEventRaiser : ReflectionEventRaiser<Quaternion>
    { }
}