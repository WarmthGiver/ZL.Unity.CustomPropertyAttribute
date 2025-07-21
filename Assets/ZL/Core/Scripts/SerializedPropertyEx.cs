#if UNITY_EDITOR

using UnityEditor;

namespace ZL.Unity
{
    public static partial class SerializedPropertyEx
    {
        public static bool TryFindProperty(this SerializedProperty instance, string fieldName, out SerializedProperty property)
        {
            var propertyPath = GetParentPath(instance) + fieldName;

            return instance.serializedObject.TryFindProperty(propertyPath, out property);
        }

        public static string GetParentPath(this SerializedProperty instance)
        {
            int lastIndex = instance.propertyPath.LastIndexOf('.');

            if (lastIndex != -1)
            {
                return instance.propertyPath[..(lastIndex + 1)];
            }

            return "";
        }

        public static bool IsPropertyTypeIn(this SerializedProperty instance, params SerializedPropertyType[] propertyTypes)
        {
            foreach (var propertyType in propertyTypes)
            {
                if (instance.propertyType == propertyType)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

#endif