using System.Collections.Generic;

using UnityEngine;

namespace ZL.Unity
{
    public static partial class ComponentEx
    {
        #region Get Component In Children

        public static bool TryGetComponentInChildren<TComponent>(this Component instance, out TComponent component)

            where TComponent : Component
        {
            return instance.transform.TryGetComponentInChildren(out component);
        }

        public static bool TryGetComponentInChildren(this Component instance, System.Type type, out Component component)
        {
            return instance.transform.TryGetComponentInChildren(type, out component);
        }

        public static bool TryGetComponentInChildrenOnly<TComponent>(this Component instance, out TComponent component)

            where TComponent : Component
        {
            return instance.transform.TryGetComponentInChildrenOnly(out component);
        }

        public static bool TryGetComponentInChildrenOnly(this Component instance, System.Type type, out Component component)
        {
            return instance.transform.TryGetComponentInChildrenOnly(type, out component);
        }

        public static bool TryGetComponentsInChildren<TComponent>(this Component instance, out List<TComponent> components)

            where TComponent : Component
        {
            return instance.transform.TryGetComponentsInChildren(out components);
        }

        public static bool TryGetComponentsInChildrenOnly<TComponent>(this Component instance, out List<TComponent> components)

            where TComponent : Component
        {
            return instance.transform.TryGetComponentsInChildrenOnly(out components);
        }

        #endregion

        #region Get Component In Parent

        public static bool TryGetComponentInParent<TComponent>(this Component instance, out TComponent component)

            where TComponent : Component
        {
            return instance.transform.TryGetComponentInParent(out component);
        }

        public static bool TryGetComponentInParent(this Component instance, System.Type type, out Component component)
        {
            return instance.transform.TryGetComponentInParent(type, out component);
        }

        public static bool TryGetComponentInParentOnly<TComponent>(this Component instance, out TComponent component)

            where TComponent : Component
        {
            return instance.transform.TryGetComponentInParentOnly(out component);
        }

        public static bool TryGetComponentInParentOnly(this Component instance, System.Type type, out Component component)
        {
            return instance.transform.TryGetComponentInParentOnly(type, out component);
        }

        public static bool TryGetComponentsInParent<TComponent>(this Component instance, out List<TComponent> component)

            where TComponent : Component
        {
            return instance.transform.TryGetComponentsInParent(out component);
        }

        public static bool TryGetComponentsInParentOnly<TComponent>(this Component instance, out List<TComponent> component)

            where TComponent : Component
        {
            return instance.transform.TryGetComponentsInParentOnly(out component);
        }

        #endregion
    }
}