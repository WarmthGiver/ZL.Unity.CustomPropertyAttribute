namespace ZL.Unity
{
    public sealed class ReadOnlyAttribute : CustomPropertyAttribute
    {
        private readonly bool isEnabled;

        public ReadOnlyAttribute(bool value)
        {
            isEnabled = !value;
        }

        #if UNITY_EDITOR

        protected override void Preset(Drawer drawer)
        {
            drawer.IsEnabled = isEnabled;
        }

        #endif
    }
}