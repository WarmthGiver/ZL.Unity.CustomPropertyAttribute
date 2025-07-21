#pragma warning disable

using System;

using System.Collections.Generic;

using UnityEngine;

namespace ZL.Unity.Demo.CustomPropertyAttributeDemo
{
    [AddComponentMenu("")]

    public sealed class HelpBoxAttributeDemo : MonoBehaviour
    {
        [Space]

        [Text("[MessageBox(\"This is message.\")]")]

        [MessageBox("This is message.")]

        [UsingCustomProperty]

        [SerializeField]

        private string test1 = "";

        [Space]

        [Text("[InfoBox(\"This is info message.\")]")]

        [InfoBox("This is info message.")]

        [UsingCustomProperty]

        [SerializeField]

        private string test2 = "";

        [Space]

        [Text("[WarningBox(\"This is warning message.\")]")]

        [WarningBox("This is warning message.")]

        [UsingCustomProperty]

        [SerializeField]

        private string test3 = "";

        [Space]

        [Text("[ErrorBox(\"This is error message.\")]")]

        [ErrorBox("This is error message.")]

        [UsingCustomProperty]

        [SerializeField]

        private string test4 = "";
    }
}