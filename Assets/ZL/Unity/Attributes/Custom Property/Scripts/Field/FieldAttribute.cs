namespace ZL.Unity
{
    public abstract class FieldAttribute : CustomPropertyAttribute
    {
        #if UNITY_EDITOR

        protected override void Preset(Drawer drawer)
        {
            drawer.IsPropertyFieldDrawn = true;
        }

        #endif
    }
}