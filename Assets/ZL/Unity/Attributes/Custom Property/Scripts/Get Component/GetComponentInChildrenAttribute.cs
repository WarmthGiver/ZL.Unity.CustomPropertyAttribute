using UnityEngine;

namespace ZL.Unity
{
    public sealed class GetComponentInChildrenAttribute : GetComponentAttribute
    {
        #if UNITY_EDITOR

        protected override Component GetComponent(Drawer drawer)
        {
            drawer.TargetComponent.TryGetComponentInChildren(drawer.fieldInfo.FieldType, out var component);

            return component;
        }

        #endif
    }
}