namespace ZL.Unity
{
    public sealed class ToggleAttribute : CustomPropertyAttribute
    {
        public readonly bool isToggled;

        public ToggleAttribute(bool value)
        {
            isToggled = value;
        }

        #if UNITY_EDITOR

        protected override void Preset(Drawer drawer)
        {
            drawer.IsToggled = isToggled;
        }

        #endif
    }
}