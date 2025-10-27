namespace ZL.Unity
{
    public sealed class AddIndentAttribute : CustomPropertyAttribute
    {
        private readonly int level;

        public AddIndentAttribute(int level = 1)
        {
            this.level = level;
        }

        #if UNITY_EDITOR

        protected override void Draw(Drawer drawer)
        {
            drawer.IndentLevel += level;
        }

        #endif
    }
}