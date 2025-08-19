#pragma warning disable

using UnityEngine;

namespace ZL.Unity.Demo.CustomPropertyAttributeDemo
{
    [AddComponentMenu("")]

    public sealed class AliasAttributeDemo : MonoBehaviour
    {
        [Space]

        [Text("Assign aliases to fields. Specify ‘Null’ as a parameter to draw an empty label. Specify ‘Empty(“”)’ to not draw a label.\r\n" +
            "\r\n" +
            "필드에 별칭을 부여합니다. 매개변수로 ‘Null’을 지정하면 빈 라벨을 그립니다. ‘Empty(\"\")’를 지정하면 라벨을 그리지 않습니다.")]

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