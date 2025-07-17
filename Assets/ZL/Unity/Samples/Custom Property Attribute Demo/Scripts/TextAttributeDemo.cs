#pragma warning disable

using System;

using System.Collections.Generic;

using UnityEngine;

namespace ZL.Unity.Demo.CustomPropertyAttributeDemo
{
    [AddComponentMenu("")]

    public sealed class TextAttributeDemo : MonoBehaviour
    {
        [Space]

        [Text("[Text(\"Hello World!\")]")]

        [Text("Hello World!")]

        [UsingCustomProperty]

        [SerializeField]

        private string test1 = "";

        [Space]

        [Text("[Text(\"<color=#FF0000>Hello World!</color>\")]", RichText = false)]

        [Text("<color=#FF0000>Hello World!</color>")]

        [UsingCustomProperty]

        [SerializeField]

        private string test2 = "";

        [Space]

        [Text("[Text(\"<color=#00FF00>Hello World!</color>\")]", RichText = false)]

        [Text("<color=#00FF00>Hello World!</color>")]

        [UsingCustomProperty]

        [SerializeField]

        private string test3 = "";

        [Space]

        [Text("[Text(\"<color=#0000FF>Hello World!</color>\")]", RichText = false)]

        [Text("<color=#0000FF>Hello World!</color>")]

        [UsingCustomProperty]

        [SerializeField]

        private string test4 = "";

        [Space]

        [Text("[Text(\"Hello World!\", TextAnchor.UpperLeft, Height = 36f)]")]

        [Text("Hello World!", TextAnchor.UpperLeft, Height = 36f)]

        [UsingCustomProperty]

        [SerializeField]

        private string test5 = "";

        [Space]

        [Text("[Text(\"Hello World!\", TextAnchor.MiddleCenter, Height = 36f)]")]

        [Text("Hello World!", TextAnchor.MiddleCenter, Height = 36f)]

        [UsingCustomProperty]

        [SerializeField]

        private string test6 = "";

        [Space]

        [Text("[Text(\"Hello World!\", TextAnchor.LowerRight, Height = 36f)]")]

        [Text("Hello World!", TextAnchor.LowerRight, Height = 36f)]

        [UsingCustomProperty]

        [SerializeField]

        private string test7 = "";

        [Space]

        [Text("[Text(\"<b>Hello World!</b>\")]", RichText = false)]

        [Text("<b>Hello World!</b>")]

        [UsingCustomProperty]

        [SerializeField]

        private string test8 = "";

        [Space]

        [Text("[Text(\"<i>Hello World!</i>\")]", RichText = false)]

        [Text("<i>Hello World!</i>")]

        [UsingCustomProperty]

        [SerializeField]

        private string test9 = "";

        [Space]

        [Text("[Text(\"<b><i>Hello World!</i></b>\")]", RichText = false)]

        [Text("<b><i>Hello World!</i></b>")]

        [UsingCustomProperty]

        [SerializeField]

        private string test10 = "";

        [Space]

        [Text("[Text(\"Hello World!\", FontSize = 24)]")]

        [Text("Hello World!", FontSize = 24)]

        [UsingCustomProperty]

        [SerializeField]

        private string test11 = "";

        [Space]

        [Text("[Text(\"Hello World!\", FontSize = 36)]")]

        [Text("Hello World!", FontSize = 36)]

        [UsingCustomProperty]

        [SerializeField]

        private string test12 = "";

        [Space]

        [Text("[Text(\"<color=#FF00FF><b><i>Hello World!</i></b></color>\",", RichText = false)]

        [Text("TextAnchor.MiddleCenter, FontSize = 36, Height = 72f)]", RichText = false)]

        [Text("<color=#FF00FF><b><i>Hello World!</i></b></color>", TextAnchor.MiddleCenter, FontSize = 36, Height = 72f)]

        [UsingCustomProperty]

        [SerializeField]

        private string test13 = "";
    }
}