#pragma warning disable

using UnityEngine;

namespace ZL.Unity.Demo.CustomPropertyAttributeDemo
{
    [AddComponentMenu("")]

    public sealed class ToggleAttributeDemo : MonoBehaviour
    {
        [Space]

        [SerializeField]

        private bool toggle = false;

        [Space]

        [ToggleIf("toggle", true)]

        [Text("[Toggle(\"toggle\", true)]")]

        [UsingCustomProperty]

        [SerializeField]

        private string test1 = "";

        [Space]

        [ToggleIf("toggle", false)]

        [Text("[Toggle(\"toggle\", false)]")]

        [UsingCustomProperty]

        [SerializeField]

        private string test2 = "";

        [Space]

        [ToggleIf("Toggle", false)]

        [Text("[Toggle(\"Toggle\", false)]")]

        [UsingCustomProperty]

        [SerializeField]

        private string test3 = "";
    }
}