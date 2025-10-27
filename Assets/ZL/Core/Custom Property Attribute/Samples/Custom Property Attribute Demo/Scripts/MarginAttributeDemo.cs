#pragma warning disable

using UnityEngine;

namespace ZL.Unity.Demo.CustomPropertyAttributeDemo
{
    [AddComponentMenu("")]

    public sealed class MarginAttributeDemo : MonoBehaviour
    {
        [Margin]

        [Text("[Margin]")]

        [UsingCustomProperty]

        [SerializeField]

        private string test1 = "";

        [Margin(16)]

        [Text("[Margin(16)]")]

        [UsingCustomProperty]

        [SerializeField]

        private int test2 = 0;

        [Margin(32)]

        [Text("[Margin(32)]")]

        [UsingCustomProperty]

        [SerializeField]

        private string test3 = "";
    }
}