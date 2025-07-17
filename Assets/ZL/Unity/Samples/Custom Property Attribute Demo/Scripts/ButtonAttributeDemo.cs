#pragma warning disable

using System;

using System.Collections.Generic;

using UnityEngine;

namespace ZL.Unity.Demo.CustomPropertyAttributeDemo
{
    [AddComponentMenu("")]

    public sealed class ButtonAttributeDemo : MonoBehaviour
	{
        [Margin]

        [Text("[Button(\"PrintText\")]")]

        [Button("PrintText")]

        [Margin]

        [Text("[Button(\"PrintText\", \"PRINT TEXT\")]")]

        [Button("PrintText", "PRINT TEXT")]

        [Margin]

        [Text("[Button(\"PrintText\", Height = 36f)]")]

        [Button("PrintText", Height = 36f)]

        [Margin]

        [Text("[Button(\"PrintText\", \"PRINT TEXT\", Height = 36f)]")]

        [Button("PrintText", "PRINT TEXT", Height = 36f)]

        [Margin]

        [Text("[Button(\"print text\")]")]

        [Button("print text")]

        [Margin]

        [UsingCustomProperty]

        [SerializeField]

        private string text = "Hello, World!";

        public void PrintText()
        {
            FixedDebug.Log(text);
        }
    }
}