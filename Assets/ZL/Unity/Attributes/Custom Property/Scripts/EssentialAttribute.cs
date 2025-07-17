using UnityEngine;

namespace ZL.Unity
{
    public sealed class EssentialAttribute : CustomPropertyAttribute
    {
        #if UNITY_EDITOR

        protected override void Draw(Drawer drawer)
        {
            if (drawer.fieldInfo.FieldType == typeof(string))
            {
                if (drawer.Property.stringValue.IsNullOrEmpty() == true)
                {
                    drawer.DrawErrorBox($"{AttributeNameTag} This field must be assigned.");
                }

                return;
            }

            if (drawer.fieldInfo.FieldType.IsSubclassOf(typeof(Object)) == false)
            {
                drawer.DrawErrorBox($"{AttributeNameTag} Field type is invalid.");

                return;
            }

            if (drawer.Property.objectReferenceValue == null)
            {
                drawer.DrawErrorBox($"{AttributeNameTag} This field must be assigned.");

                return;
            }
        }

        #endif
    }
}