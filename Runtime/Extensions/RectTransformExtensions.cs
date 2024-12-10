using UnityEngine;

namespace DomesUnityToolkit.Extensions
{
    public static class RectTransformExtensions
    {

        public static Rect GetScreenRect(this RectTransform rectTransform)
        {
            var corners = new Vector3[4];
            rectTransform.GetWorldCorners(corners);

            var topLeft = RectTransformUtility.WorldToScreenPoint(null, corners[0]);
            var bottomRight = RectTransformUtility.WorldToScreenPoint(null, corners[2]);

            return new Rect(topLeft.x, topLeft.y, bottomRight.x - topLeft.x, bottomRight.y - topLeft.y);
        }

        public static Vector2 ScreenPointToRectTransformPoint(this RectTransform rectTransform, Vector2 screenPoint)
        {
            RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, screenPoint, null, out var localPoint);
            return localPoint;
        }
    }
}