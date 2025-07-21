#pragma warning disable

using System;

using System.Collections.Generic;

using UnityEngine;

namespace ZL.Unity.Demo.CustomPropertyAttributeDemo
{
    [AddComponentMenu("")]

    public sealed class AddIndentAttributeDemo : MonoBehaviour
    {
        [Space]

        [Text("[AddIndent(-1)]")]

        [AddIndent(-1)]

        [UsingCustomProperty]

        [SerializeField]

        private string test1 = "";

        [Space]

        [Text("[AddIndent(0)]")]

        [AddIndent(0)]

        [UsingCustomProperty]

        [SerializeField]

        private string test2 = "";

        [Space]

        [Text("[AddIndent(1)]")]

        [AddIndent(1)]

        [UsingCustomProperty]

        [SerializeField]

        private string test3 = "";
    }
}