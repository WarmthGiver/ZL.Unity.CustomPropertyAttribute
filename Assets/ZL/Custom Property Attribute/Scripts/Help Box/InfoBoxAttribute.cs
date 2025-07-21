namespace ZL.Unity
{
    public sealed class InfoBoxAttribute : MessageBoxAttribute
    {
        public InfoBoxAttribute(string message) : base(message)
        {

        }

        #if UNITY_EDITOR

        protected override void Draw(Drawer drawer)
        {
            drawer.DrawInfoBox(message);
        }

        #endif
    }
}