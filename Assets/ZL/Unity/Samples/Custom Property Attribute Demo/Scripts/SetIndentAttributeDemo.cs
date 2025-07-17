#pragma warning disable

using System;

using System.Collections.Generic;

using UnityEngine;

namespace ZL.Unity.Demo.CustomPropertyAttributeDemo
{
    [AddComponentMenu("")]

    public sealed class SetIndentAttributeDemo : MonoBehaviour
    {
        [Space]

        [Text("[SetIndent(-1)]")]

        [SetIndent(-1)]

        [UsingCustomProperty]

        [SerializeField]

        private string test1 = "";

        [Space]

        [Text("[SetIndent(0)]")]

        [SetIndent(0)]

        [UsingCustomProperty]

        [SerializeField]

        private string test2 = "";

        [Space]

        [Text("[SetIndent(1)]")]

        [SetIndent(1)]

        [UsingCustomProperty]

        [SerializeField]

        private string test3 = "";
    }
}