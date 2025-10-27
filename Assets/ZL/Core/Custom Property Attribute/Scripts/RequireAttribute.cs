using System;

namespace ZL.Unity
{
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]

    public sealed class RequireAttribute : GetComponentAttribute
    {
        #if UNITY_EDITOR

        protected override void Preset(Drawer drawer)
        {
            base.Preset(drawer);

            if (drawer.Property.objectReferenceValue == null)
            {
                drawer.Property.objectReferenceValue = drawer.TargetComponent.gameObject.AddComponent(drawer.fieldInfo.FieldType);
            }
        }

        #endif
    }
}