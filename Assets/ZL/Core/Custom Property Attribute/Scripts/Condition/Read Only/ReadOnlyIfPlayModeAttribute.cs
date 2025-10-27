using UnityEngine;

namespace ZL.Unity
{
    public sealed class ReadOnlyIfPlayModeAttribute : CustomPropertyAttribute
    {
        private readonly bool condition; 

        public ReadOnlyIfPlayModeAttribute(bool condition)
        {
            this.condition = condition;
        }

        #if UNITY_EDITOR

        protected override void Preset(Drawer drawer)
        {
            bool IsEnabled = !Application.isPlaying;

            if (condition == false)
            {
                IsEnabled = !IsEnabled;
            }

            drawer.IsEnabled = IsEnabled;
        }

        #endif
    }
}