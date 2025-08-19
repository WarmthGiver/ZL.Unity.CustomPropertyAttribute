using System;

using UnityEngine;

namespace ZL.Unity
{
    public static partial class GameObjectEx
    {
        public static GameObject AddComponents(this GameObject instance, params Type[] types)
        {
            foreach (var component in types)
            {
                instance.AddComponent(component);
            }

            return instance;
        }
    }
}