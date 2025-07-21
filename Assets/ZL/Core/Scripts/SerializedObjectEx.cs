#if UNITY_EDITOR

using UnityEditor;

using UnityEngine;

namespace ZL.Unity
{
    public static partial class SerializedObjectEx
    {
        public static void ScriptField(this SerializedObject instance)
        {
            var enabled_backup = GUI.enabled;

            GUI.enabled = false;

            EditorGUILayout.PropertyField(instance.FindProperty("m_Script"));

            GUI.enabled = enabled_backup;
        }

        public static bool TryFindProperty(this SerializedObject instance, string propertyPath, out SerializedProperty property)
        {
            property = instance.FindProperty(propertyPath);

            return property != null;
        }
    }
}

#endif