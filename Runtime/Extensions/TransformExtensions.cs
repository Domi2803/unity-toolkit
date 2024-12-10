﻿using UnityEngine;

namespace DomesUnityToolkit.Extensions
{
    public static class TransformExtensions
    {
        public static Transform FindChildWithTag(this Transform parent, string tag)
        {
            if(parent.childCount == 0)
            {
                return null;
            }

            foreach (Transform child in parent)
            {
                if (child.CompareTag(tag))
                {
                    return child;
                }

                var childTransform = FindChildWithTag(child, tag);
                if (childTransform != null)
                {
                    return childTransform;
                }
            }

            return null;
        }
    }
}