#pragma warning disable

using System;

using System.Collections.Generic;

using UnityEngine;

namespace ZL.Unity.Demo.CustomPropertyAttributeDemo
{
    [AddComponentMenu("")]

    public sealed class LineAttributeDemo : MonoBehaviour
    {
        [Space]

        [Text("[Line]")]

        [Line]

        [UsingCustomProperty]

        [SerializeField]

        private string test1 = "";

        [Space]

        [Text("[Line(Margin = 2)]")]

        [Line(Margin = 2)]

        [UsingCustomProperty]

        [SerializeField]

        private string test2 = "";

        [Space]

        [Text("[Line(\"#ff0000\")]")]

        [Line("#ff0000")]

        [UsingCustomProperty]

        [SerializeField]

        private string test3 = "";

        [Space]

        [Text("[Line(\"#ff8000\", Thickness = 2)]")]

        [Line("#ff8000", Thickness = 2)]

        [UsingCustomProperty]

        [SerializeField]

        private string test4 = "";

        [Space]

        [Text("[Line(\"#ffff00\", Thickness = 3)]")]

        [Line("#ffff00", Thickness = 3)]

        [UsingCustomProperty]

        [SerializeField]

        private string test5 = "";

        [Space]

        [Text("[Line(\"#80ff00\", Thickness = 4)]")]

        [Line("#80ff00", Thickness = 4)]

        [UsingCustomProperty]

        [SerializeField]

        private string test6 = "";

        [Space]

        [Text("[Line(\"#00ff00\", Thickness = 5)]")]

        [Line("#00ff00", Thickness = 5)]

        [UsingCustomProperty]

        [SerializeField]

        private string test7 = "";

        [Space]

        [Text("[Line(\"#00ff80\", Thickness = 6)]")]

        [Line("#00ff80", Thickness = 6)]

        [UsingCustomProperty]

        [SerializeField]

        private string test8 = "";

        [Space]

        [Text("[Line(\"#00ffff\", Thickness = 7)]")]

        [Line("#00ffff", Thickness = 7)]

        [UsingCustomProperty]

        [SerializeField]

        private string test9 = "";

        [Space]

        [Text("[Line(\"#0000ff\", Thickness = 8)]")]

        [Line("#0000ff", Thickness = 8)]

        [UsingCustomProperty]

        [SerializeField]

        private string test10 = "";

        [Space]

        [Text("[Line(\"#8000ff\", Thickness = 9)]")]

        [Line("#8000ff", Thickness = 9)]

        [UsingCustomProperty]

        [SerializeField]

        private string test11 = "";

        [Space]

        [Text("[Line(\"#ff00ff\", Thickness = 10)]")]

        [Line("#ff00ff", Thickness = 10)]

        [UsingCustomProperty]

        [SerializeField]

        private string test12 = "";

        [Space]

        [Text("[Line(\"#ff0080\", Thickness = 11)]")]

        [Line("#ff0080", Thickness = 11)]

        [UsingCustomProperty]

        [SerializeField]

        private string test13 = "";
    }
}