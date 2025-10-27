#if UNITY_EDITOR

using UnityEditor;

#endif

namespace ZL.Unity
{
    public sealed class TagFieldAttribute : FieldAttribute
    {
        #if UNITY_EDITOR

        protected override void Draw(Drawer drawer)
        {
            if (drawer.Property.propertyType != SerializedPropertyType.String)
            {
                drawer.DrawErrorBox($"{AttributeNameTag} Property type is mismatch.");

                return;
            }

            drawer.DrawTagField();
        }

        #endif
    }
}