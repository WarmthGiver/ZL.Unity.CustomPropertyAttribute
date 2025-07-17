using UnityEngine;

namespace ZL.Unity
{
    public sealed class ReadOnlyIfPlayModeAttribute : CustomPropertyAttribute
    {
        #if UNITY_EDITOR

        protected override void Draw(Drawer drawer)
        {
            drawer.IsEnabled = !Application.isPlaying;
        }

        #endif
    }
}