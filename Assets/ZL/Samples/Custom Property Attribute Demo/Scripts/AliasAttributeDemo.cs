#pragma warning disable

using UnityEngine;

namespace ZL.Unity.Demo.CustomPropertyAttributeDemo
{
    [AddComponentMenu("")]

    public sealed class AliasAttributeDemo : MonoBehaviour
    {
        [Space]

        [Text("[Alias(\"TEST 1\")]")]

        [Alias("TEST 1")]

        [UsingCustomProperty]

        [SerializeField]

        private string test1 = "";

        [Space]

        [Text("[Alias(null)]")]

        [Alias(null)]

        [UsingCustomProperty]

        [SerializeField]

        private string test2 = "";

        [Space]

        [Text("[Alias(\"\")]")]

        [Alias("")]

        [UsingCustomProperty]

        [SerializeField]

        private string test3 = "";

        [Space]

        [Text("[LabelField]")]

        [Text("[Alias(\"\")]")]

        [LabelField]

        [Alias("")]

        [PropertyField]

        [UsingCustomProperty]

        [SerializeField]

        private string test4 = "";
    }
}