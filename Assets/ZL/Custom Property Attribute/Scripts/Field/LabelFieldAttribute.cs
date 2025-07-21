namespace ZL.Unity
{
    public sealed class LabelFieldAttribute : FieldAttribute
    {
        #if UNITY_EDITOR

        protected override void Draw(Drawer drawer)
        {
            drawer.DrawLabelField();
        }

        #endif
    }
}