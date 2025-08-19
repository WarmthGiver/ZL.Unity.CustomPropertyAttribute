using System;

using System.Collections.Generic;

using UnityEngine;

namespace ZL.Unity
{
    public static partial class TransformEx
    {
        #region Get Component In Children

        public static bool TryGetComponentInChildren<TComponent>(this Transform instance, out TComponent component)

            where TComponent : Component
        {
            if (instance.TryGetComponent(out component) == false)
            {
                component = GetComponentInChildrenOnly<TComponent>(instance);
            }

            return component != null;
        }

        public static bool TryGetComponentInChildren(this Transform instance, Type type, out Component component)
        {
            if (instance.TryGetComponent(type, out component) == false)
            {
                component = GetComponentInChildrenOnly(instance, type);
            }

            return component != null;
        }

        public static bool TryGetComponentInChildrenOnly<TComponent>(this Transform instance, out TComponent component)

            where TComponent : Component
        {
            component = GetComponentInChildrenOnly<TComponent>(instance);

            return component != null;
        }

        public static bool TryGetComponentInChildrenOnly(this Transform instance, Type type, out Component component)
        {
            component = GetComponentInChildrenOnly(instance, type);

            return component != null;
        }

        private static TComponent GetComponentInChildrenOnly<TComponent>(this Transform instance)

            where TComponent : Component
        {
            foreach (Transform child in instance)
            {
                if (child.TryGetComponent(out TComponent component) == true)
                {
                    return component;
                }

                component = GetComponentInChildrenOnly<TComponent>(child);

                if (component != null)
                {
                    return component;
                }
            }

            return null;
        }

        private static Component GetComponentInChildrenOnly(this Transform instance, Type type)
        {
            foreach (Transform child in instance)
            {
                if (child.TryGetComponent(type, out var component) == true)
                {
                    return component;
                }

                component = GetComponentInChildrenOnly(child, type);

                if (component != null)
                {
                    return component;
                }
            }

            return null;
        }

        public static bool TryGetComponentsInChildren<TComponent>(this Transform instance, out List<TComponent> components)

            where TComponent : Component
        {
            components = new List<TComponent>();

            if (instance.TryGetComponent(out TComponent component) == true)
            {
                components.Add(component);
            }

            GetComponentsInChildrenOnly(instance, ref components);

            return components.Count > 0;
        }

        public static bool TryGetComponentsInChildrenOnly<TComponent>(this Transform instance, out List<TComponent> components)

            where TComponent : Component
        {
            components = new List<TComponent>();

            GetComponentsInChildrenOnly(instance, ref components);

            return components.Count > 0;
        }

        private static void GetComponentsInChildrenOnly<TComponent>(this Transform instance, ref List<TComponent> components)

            where TComponent : Component
        {
            foreach (Transform child in instance)
            {
                if (child.TryGetComponent(out TComponent component) == true)
                {
                    components.Add(component);
                }

                GetComponentsInChildrenOnly(child, ref components);
            }
        }

        #endregion

        #region Get Component In Parent

        public static bool TryGetComponentInParent<TComponent>(this Transform instance, out TComponent component)

            where TComponent : Component
        {
            component = GetComponentInParent<TComponent>(instance);

            return component != null;
        }

        public static bool TryGetComponentInParent(this Transform instance, Type type, out Component component)
        {
            component = GetComponentInParent(instance, type);

            return component != null;
        }

        public static bool TryGetComponentInParentOnly<TComponent>(this Transform instance, out TComponent component)

            where TComponent : Component
        {
            component = GetComponentInParent<TComponent>(instance.parent);

            return component != null;
        }

        public static bool TryGetComponentInParentOnly(this Transform instance, Type type, out Component component)
        {
            component = GetComponentInParent(instance.parent, type);

            return component != null;
        }

        private static TComponent GetComponentInParent<TComponent>(this Transform instance)

            where TComponent : Component
        {
            while (instance != null)
            {
                if (instance.TryGetComponent(out TComponent component) == true)
                {
                    return component;
                }

                instance = instance.parent;
            }

            return null;
        }

        private static Component GetComponentInParent(this Transform instance, Type type)
        {
            while (instance != null)
            {
                if (instance.TryGetComponent(type, out var component) == true)
                {
                    return component;
                }

                instance = instance.parent;
            }

            return null;
        }

        public static bool TryGetComponentsInParent<TComponent>(this Transform instance, out List<TComponent> components)

            where TComponent : Component
        {
            components = new List<TComponent>();

            if (instance.TryGetComponent<TComponent>(out var component) == true)
            {
                components.Add(component);
            }

            GetComponentsInParentOnly(instance, ref components);

            return components.Count > 0;
        }

        public static bool TryGetComponentsInParentOnly<TComponent>(this Transform instance, out List<TComponent> components)

            where TComponent : Component
        {
            components = new List<TComponent>();

            GetComponentsInParentOnly(instance, ref components);

            return components.Count > 0;
        }

        private static void GetComponentsInParentOnly<TComponent>(this Transform instance, ref List<TComponent> components)

            where TComponent : Component
        {
            var parent = instance.parent;

            while (parent != null)
            {
                if (parent.TryGetComponent<TComponent>(out var component) == true)
                {
                    components.Add(component);
                }

                parent = parent.parent;
            }
        }

        #endregion
    }
}