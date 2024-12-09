using UnityEngine;

namespace DomesUnityToolkit.ReflectionEventRaiser
{
    [AddComponentMenu("Events/Reflection Event Raiser/Vector2 Event Raiser")]
#if ODIN_INSPECTOR
    [Sirenix.OdinInspector.HideMonoScript]
#endif
    public class Vector2ReflectionEventRaiser : ReflectionEventRaiser<Vector2>
    { }
}