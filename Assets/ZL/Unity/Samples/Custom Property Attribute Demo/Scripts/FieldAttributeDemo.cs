#pragma warning disable

using UnityEngine;

namespace ZL.Unity.Demo.CustomPropertyAttributeDemo
{
    [AddComponentMenu("")]

    public sealed class FieldAttributeDemo : MonoBehaviour
    {
        [Space]

        [Text("[PropertyField]")]

        [PropertyField]

        [UsingCustomProperty]

        [SerializeField]

        private string test1 = "";

        [Space]

        [Text("[LabelField]")]

        [LabelField]

        [UsingCustomProperty]

        [SerializeField]

        private string test2 = "";

        [Space]

        [Text("[LayerField]")]

        [LayerField]

        [UsingCustomProperty]

        [SerializeField]

        private int test3 = 0;

        [Space]

        [Text("[LayerField]")]

        [LayerField]

        [UsingCustomProperty]

        [SerializeField]

        private string test4 = "";

        [Space]

        [Text("[TagField]")]

        [TagField]

        [UsingCustomProperty]

        [SerializeField]

        private string test5 = "Untagged";

        [Space]

        [Text("[TagField]")]

        [TagField]

        [UsingCustomProperty]

        [SerializeField]

        private int test6 = 0;
    }
}