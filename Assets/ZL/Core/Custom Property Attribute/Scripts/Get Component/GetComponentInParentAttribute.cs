using UnityEngine;

namespace ZL.Unity
{
    public sealed class GetComponentInParentAttribute : GetComponentAttribute
    {
        #if UNITY_EDITOR

        protected override Component GetComponent(Drawer drawer)
        {
            drawer.TargetComponent.TryGetComponentInParent(drawer.fieldInfo.FieldType, out var component);

            return component;
        }

        #endif
    }
}