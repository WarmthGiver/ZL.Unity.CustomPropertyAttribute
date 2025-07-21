using UnityEngine;

namespace ZL.Unity
{
    public sealed class PreviewAttribute : CustomPropertyAttribute
    {
        #if UNITY_EDITOR

        protected override void Draw(Drawer drawer)
        {
            if (drawer.fieldInfo.FieldType.IsSubclassOf(typeof(Object)) == false)
            {
                drawer.DrawErrorBox($"{AttributeNameTag} Field type is invalid.");

                return;
            }

            drawer.DrawPreview();
        }

        #endif
    }
}