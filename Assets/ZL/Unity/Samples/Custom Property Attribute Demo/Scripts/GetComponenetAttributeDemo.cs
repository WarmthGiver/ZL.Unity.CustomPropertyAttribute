#pragma warning disable

using System;

using System.Collections.Generic;

using UnityEngine;

namespace ZL.Unity.Demo.CustomPropertyAttributeDemo
{
    [AddComponentMenu("")]

    public sealed class GetComponenetAttributeDemo : MonoBehaviour
    {
        [Space]

        [Text("[GetComponent]")]

        [GetComponent]

        [UsingCustomProperty]

        [SerializeField]

        private Transform test1 = null;

        [Space]

        [Text("[GetComponentInParent]")]

        [GetComponentInParent]

        [UsingCustomProperty]

        [SerializeField]

        private Transform test2 = null;

        [Space]

        [Text("[GetComponentInParentOnly]")]

        [GetComponentInParentOnly]

        [UsingCustomProperty]

        [SerializeField]

        private Transform test3 = null;

        [Space]

        [Text("[GetComponentInChildren]")]

        [GetComponentInChildren]

        [UsingCustomProperty]

        [SerializeField]

        private Transform test4 = null;

        [Space]

        [Text("[GetComponentInChildrenOnly]")]

        [GetComponentInChildrenOnly]

        [UsingCustomProperty]

        [SerializeField]

        private Transform test5 = null;

        [Space]

        [Text("[GetComponent]")]

        [GetComponent]

        [UsingCustomProperty]

        [SerializeField]

        private string test6 = "";
    }
}