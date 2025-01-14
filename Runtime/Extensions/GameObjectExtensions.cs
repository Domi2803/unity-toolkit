using UnityEngine;

namespace DomesUnityToolkit.Extensions {
    public static class GameObjectExtensions {
        public static T GetOrAdd<T>(this GameObject gameObject) where T : Component {
            T component = gameObject.GetComponent<T>();
            return component != null ? component : gameObject.AddComponent<T>();
        }

        public static Transform FindChildWithTag(this GameObject parent, string tag)
        {
            return parent.transform.FindChildWithTag(tag);
        }

        public static void SetAllLayers(this GameObject gameObject, int layer)
        {
            gameObject.layer = layer;
            foreach (Transform child in gameObject.transform)
            {
                child.gameObject.SetAllLayers(layer);
            }
        }

        // Go up the hierarchy and try to find a component of type T
        public static bool TryGetComponentInParents<T>(this GameObject gameObject, out T component) where T : Component
        {
            component = gameObject.GetComponent<T>();
            if (component != null)
            {
                return true;
            }

            Transform parent = gameObject.transform.parent;
            while (parent != null)
            {
                component = parent.GetComponent<T>();
                if (component != null)
                {
                    return true;
                }

                parent = parent.parent;
            }

            return false;
        }

        public static bool TryGetComponentInChildren<T>(this GameObject gameObject, out T component) where T : Component
        {
            component = gameObject.GetComponentInChildren<T>();
            return component != null;
        }

        public static bool HasComponent<T>(this GameObject gameObject) where T : Component
        {
            return gameObject.TryGetComponent<T>(out _);
        }
    }
}