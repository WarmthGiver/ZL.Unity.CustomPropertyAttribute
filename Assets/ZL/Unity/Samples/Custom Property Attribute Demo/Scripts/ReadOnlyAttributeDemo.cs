#pragma warning disable

using UnityEngine;

namespace ZL.Unity.Demo.CustomPropertyAttributeDemo
{
    [AddComponentMenu("")]

    public sealed class ReadOnlyAttributeDemo : MonoBehaviour
    {
        [Space]

        [Text("[ReadOnly(true)]")]

        [ReadOnly(true)]

        [UsingCustomProperty]

        [SerializeField]

        private string test1 = "";

        [Space]

        private bool isReadOnly = false;

        [Space]

        [Text("[ReadOnlyIf(true)]")]

        [ReadOnlyIf("isReadOnly", true)]

        [UsingCustomProperty]

        [SerializeField]

        private string test2 = "";

        [Space]

        [Text("[ReadOnlyIfEditMode]")]

        [ReadOnlyIfEditMode]

        [UsingCustomProperty]

        [SerializeField]

        private string test3 = "";

        [Space]

        [Text("[ReadOnlyIfPlayMode]")]

        [ReadOnlyIfPlayMode]

        [UsingCustomProperty]

        [SerializeField]

        private string test4 = "";
    }
}