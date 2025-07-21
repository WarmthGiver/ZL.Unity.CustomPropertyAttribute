namespace ZL.Unity
{
    public sealed class WarningBoxAttribute : MessageBoxAttribute
    {
        public WarningBoxAttribute(string message) : base(message)
        {

        }


        #if UNITY_EDITOR

        protected override void Draw(Drawer drawer)
        {
            drawer.DrawWarningBox(message);
        }

        #endif
    }
}