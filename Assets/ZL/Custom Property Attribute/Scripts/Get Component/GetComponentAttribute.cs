using UnityEngine;

namespace ZL.Unity
{
    public class GetComponentAttribute : CustomPropertyAttribute
    {
        #if UNITY_EDITOR

        private bool isTypeValid = false;

        protected override void Initialize(Drawer drawer)
        {
            isTypeValid = drawer.fieldInfo.FieldType.IsSubclassOf(typeof(Component));
        }

        protected override void Preset(Drawer drawer)
        {
            if (isTypeValid == false)
            {
                drawer.DrawErrorBox($"{AttributeNameTag} Field type is invalid.");

                return;
            }

            drawer.Property.objectReferenceValue = GetComponent(drawer);
        }

        protected virtual Component GetComponent(Drawer drawer)
        {
            drawer.TargetComponent.TryGetComponent(drawer.fieldInfo.FieldType, out var component);

            return component;
        }

        #endif
    }
}