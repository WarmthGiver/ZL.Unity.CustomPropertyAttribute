#pragma warning disable

using System;

using System.Collections.Generic;

using UnityEngine;

namespace ZL.Unity.Demo.CustomPropertyAttributeDemo
{
    [AddComponentMenu("")]

    public sealed class PreviewAttributeDemo : MonoBehaviour
    {
        [Space]

        [PropertyField]

        [Preview]

        [UsingCustomProperty]

        [SerializeField]

        private Texture test1 = null;

        [Space]

        [PropertyField]

        [Preview]

        [UsingCustomProperty]

        [SerializeField]

        private Texture2D test2 = null;

        [Space]

        [PropertyField]

        [Preview]

        [UsingCustomProperty]

        [SerializeField]

        private Sprite test3 = null;

        [Space]

        [PropertyField]

        [Preview]

        [UsingCustomProperty]

        [SerializeField]

        private GameObject test4 = null;

        [Space]

        [PropertyField]

        [Preview]

        [UsingCustomProperty]

        [SerializeField]

        private Material test5 = null;
    }
}