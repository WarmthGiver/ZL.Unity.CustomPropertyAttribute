using System;

using System.Diagnostics;

using System.Reflection;

#if UNITY_EDITOR

using UnityEditor;

#endif

using UnityEngine;

using Debug = UnityEngine.Debug;

using Object = UnityEngine.Object;

namespace ZL.Unity
{
    public static partial class FixedDebug
    {
        [Conditional("UNITY_EDITOR")]

        public static void Assert(bool condition, object message, Object context = null)
        {
            Debug.Assert(condition, message, context);
        }

        [Conditional("UNITY_EDITOR")]

        public static void Assert(bool condition, object message)
        {
            Debug.Assert(condition, message);
        }

        [Conditional("UNITY_EDITOR")]

        public static void Assert(bool condition, Object context = null)
        {
            Debug.Assert(condition, context);
        }

        [Conditional("UNITY_EDITOR")]

        public static void AssertFormat(bool condition, Object context, string format, params object[] args)
        {
            Debug.AssertFormat(condition, context, format, args);
        }

        [Conditional("UNITY_EDITOR")]

        public static void AssertFormat(bool condition, string format, params object[] args)
        {
            Debug.AssertFormat(condition, format, args);
        }

        [Conditional("UNITY_EDITOR")]

        public static void Log(object message, Object context = null)
        {
            Debug.Log(message, context);
        }

        [Conditional("UNITY_EDITOR")]

        public static void LogFormat(Object context, string format, params object[] args)
        {
            Debug.LogFormat(context, format, args);
        }

        [Conditional("UNITY_EDITOR")]

        public static void LogFormat(string format, params object[] args)
        {
            Debug.LogFormat(format, args);
        }

        [Conditional("UNITY_EDITOR")]

        public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params object[] args)
        {
            Debug.LogFormat(logType, logOptions, context, format, args);
        }

        [Conditional("UNITY_EDITOR")]

        public static void LogFormat(LogType logType, LogOption logOptions, string format, params object[] args)
        {
            Debug.LogFormat(logType, logOptions, null, format, args);
        }

        [Conditional("UNITY_EDITOR")]

        public static void LogAssertion(object message, Object context = null)
        {
            Debug.LogAssertion(message, context);
        }

        [Conditional("UNITY_EDITOR")]

        public static void LogAssertionFormat(Object context, string format, params object[] args)
        {
            Debug.LogAssertionFormat(context, format, args);
        }

        [Conditional("UNITY_EDITOR")]

        public static void LogAssertionFormat(string format, params object[] args)
        {
            Debug.LogAssertionFormat(format, args);
        }

        [Conditional("UNITY_EDITOR")]

        public static void LogWarning(object message, Object context = null)
        {
            Debug.LogWarning(message, context);
        }

        [Conditional("UNITY_EDITOR")]

        public static void LogWarningFormat(Object context, string format, params object[] args)
        {
            Debug.LogWarningFormat(context, format, args);
        }

        [Conditional("UNITY_EDITOR")]

        public static void LogWarningFormat(string format, params object[] args)
        {
            Debug.LogWarningFormat(format, args);
        }

        [Conditional("UNITY_EDITOR")]

        public static void LogError(object message, Object context = null)
        {
            Debug.LogError(message, context);
        }

        [Conditional("UNITY_EDITOR")]

        public static void LogErrorFormat(Object context, string format, params object[] args)
        {
            Debug.LogErrorFormat(context, format, args);
        }

        [Conditional("UNITY_EDITOR")]

        public static void LogErrorFormat(string format, params object[] args)
        {
            Debug.LogErrorFormat(format, args);
        }

        [Conditional("UNITY_EDITOR")]

        public static void LogException(Exception exception, Object context = null)
        {
            Debug.LogException(exception, context);
        }

        [Conditional("UNITY_EDITOR")]

        public static void DrawLine(in Vector3 start, in Vector3 end)
        {
            Debug.DrawLine(start, end);
        }

        [Conditional("UNITY_EDITOR")]

        public static void DrawLine(in Vector3 start, in Vector3 end, in Color color)
        {
            Debug.DrawLine(start, end, color);
        }

        [Conditional("UNITY_EDITOR")]

        public static void DrawLine(in Vector3 start, in Vector3 end, in Color color, float duration)
        {
            Debug.DrawLine(start, end, color, duration);
        }

        [Conditional("UNITY_EDITOR")]

        public static void DrawLine(in Vector3 start, in Vector3 end, in Color color, float duration, bool depthTest)
        {
            Debug.DrawLine(start, end, color, duration, depthTest);
        }

        [Conditional("UNITY_EDITOR")]

        public static void DrawRay(in Vector3 start, in Vector3 dir, in Color color, float duration, bool depthTest)
        {
            Debug.DrawRay(start, dir, color, duration, depthTest);
        }

        [Conditional("UNITY_EDITOR")]

        public static void DrawRay(in Vector3 start, in Vector3 dir, in Color color, float duration)
        {
            Debug.DrawRay(start, dir, color, duration);
        }

        [Conditional("UNITY_EDITOR")]

        public static void DrawRay(in Vector3 start, in Vector3 dir, in Color color)
        {
            Debug.DrawRay(start, dir, color);
        }

        [Conditional("UNITY_EDITOR")]

        public static void DrawRay(in Vector3 start, in Vector3 dir)
        {
            Debug.DrawRay(start, dir);
        }

        [Conditional("UNITY_EDITOR")]

        public static void ClearLog()
        {
            #if UNITY_EDITOR

            var assembly = Assembly.GetAssembly(typeof(Editor));

            var type = assembly.GetType("UnityEditor.LogEntries");

            var method = type.GetMethod("Clear");
            
            method.Invoke(new object(), null);

            #endif
        }
    }
}