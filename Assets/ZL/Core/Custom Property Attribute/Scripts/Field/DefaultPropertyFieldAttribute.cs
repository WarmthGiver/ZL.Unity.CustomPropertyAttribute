namespace ZL.Unity
{
    public sealed class DefaultPropertyFieldAttribute : FieldAttribute
    {
        #if UNITY_EDITOR

        protected override void Draw(Drawer drawer)
        {
            drawer.DrawDefaultPropertyField();
        }

        #endif
    }
}