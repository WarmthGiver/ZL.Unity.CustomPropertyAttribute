#pragma warning disable

using UnityEngine;

namespace ZL.Unity.Demo.CustomPropertyAttributeDemo
{
    [AddComponentMenu("")]

    public sealed class EssentialAttributeDemo : MonoBehaviour
    {
        [Space]

        [Text("[Essential]")]

        [Essential]

        [UsingCustomProperty]

        [SerializeField]

        private Transform test1 = null;

        [Space]

        [Text("[Essential]")]

        [Essential]

        [UsingCustomProperty]

        [SerializeField]

        private string test2 = "";
    }
}