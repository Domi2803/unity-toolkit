using UnityEngine;

namespace DomesUnityToolkit.ReflectionEventRaiser
{
    [AddComponentMenu("Events/Reflection Event Raiser/Vector3 Event Raiser")]
#if ODIN_INSPECTOR
    [Sirenix.OdinInspector.HideMonoScript]
#endif
    public class Vector3ReflectionEventRaiser : ReflectionEventRaiser<Vector3>
    { }
}