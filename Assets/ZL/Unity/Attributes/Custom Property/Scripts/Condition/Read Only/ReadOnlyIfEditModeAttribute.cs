using UnityEngine;

namespace ZL.Unity
{
    public sealed class ReadOnlyIfEditModeAttribute : CustomPropertyAttribute
    {
        #if UNITY_EDITOR

        protected override void Draw(Drawer drawer)
        {
            drawer.IsEnabled = Application.isPlaying;
        }

        #endif
    }
}