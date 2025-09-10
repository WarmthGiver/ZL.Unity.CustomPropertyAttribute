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

        private Transform transform = null;

        [Space]

        [Text("[Require]")]

        [Require]

        [UsingCustomProperty]

        [SerializeField]

        private CapsuleCollider collider = null;

        [Space]

        [Text("[Require]")]

        [Require]

        [UsingCustomProperty]

        [SerializeField]

        private Rigidbody rigidbody = null;
    }
}