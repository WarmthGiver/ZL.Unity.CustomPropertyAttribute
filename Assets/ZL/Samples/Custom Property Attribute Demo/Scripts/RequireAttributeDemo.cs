#pragma warning disable

using UnityEngine;

namespace ZL.Unity.Demo.CustomPropertyAttributeDemo
{
    [AddComponentMenu("")]

    public sealed class RequireAttributeDemo : MonoBehaviour
    {
        [Space]

        [Text("[Require]")]

        [Require]

        [UsingCustomProperty]

        [SerializeField]

        private RequireTest1 test1 = null;

        [Space]

        [Text("[Require]")]

        [Require]

        [UsingCustomProperty]

        [SerializeField]

        private RequireTest2 test2 = null;

        [Space]

        [Text("[Require]")]

        [Require]

        [UsingCustomProperty]

        [SerializeField]

        private RequireTest3 test3 = null;
    }
}