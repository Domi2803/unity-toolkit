using UnityEngine;

namespace DomesUnityToolkit.ReflectionEventRaiser
{
    [AddComponentMenu("Events/Reflection Event Raiser/Vector4 Event Raiser")]
#if ODIN_INSPECTOR
    [Sirenix.OdinInspector.HideMonoScript]
#endif
    public class Vector4ReflectionEventRaiser : ReflectionEventRaiser<Vector4>
    { }
}