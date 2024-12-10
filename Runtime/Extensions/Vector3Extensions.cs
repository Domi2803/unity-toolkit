using UnityEngine;

namespace DomesUnityToolkit.Extensions {
    public static class Vector3Extensions {
        /// <summary>
        /// Sets any values of the Vector3
        /// </summary>
        public static Vector3 With(this Vector3 vector, float? x = null, float? y = null, float? z = null) {
            return new Vector3(x ?? vector.x, y ?? vector.y, z ?? vector.z);
        }
    
        /// <summary>
        /// Adds to any values of the Vector3
        /// </summary>
        public static Vector3 Add(this Vector3 vector, float? x = null, float? y = null, float? z = null) {
            return new Vector3(vector.x + (x ?? 0), vector.y + (y ?? 0), vector.z + (z ?? 0));
        }

        public static Vector2 xy(this Vector3 vector)
        {
            return new Vector2(vector.x, vector.y);
        }

        public static Vector2 xz(this Vector3 vector)
        {
            return new Vector2(vector.x, vector.z);
        }

        public static Vector2 yx(this Vector3 vector)
        {
            return new Vector2(vector.y, vector.x);
        }

        public static Vector2 yz(this Vector3 vector)
        {
            return new Vector2(vector.y, vector.z);
        }

        public static Vector2 zx(this Vector3 vector)
        {
            return new Vector2(vector.z, vector.x);
        }

        public static Vector2 zy(this Vector3 vector)
        {
            return new Vector2(vector.z, vector.y);
        }


    }
}