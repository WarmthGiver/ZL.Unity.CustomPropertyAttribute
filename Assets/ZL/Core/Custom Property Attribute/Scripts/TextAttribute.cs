using UnityEngine;

namespace ZL.Unity
{
    public sealed class TextAttribute : CustomPropertyAttribute
    {
        private readonly GUIContent label;

        private readonly GUIStyle style;

        public bool WordWrap = true;

        public int FontSize { get; set; } = defaultFontSize;

        public bool RichText { get; set; } = true;

        public float Height { get; set; } = 0f;

        public TextAttribute(string text, TextAnchor alignment = TextAnchor.UpperLeft)
        {
            label = new GUIContent(text);

            style = new GUIStyle()
            {
                //wordWrap = true,

                alignment = alignment,

                //richText = true,
            };

            style.normal.textColor = DefaultTextColor;
        }

        #if UNITY_EDITOR

        protected override void Initialize(Drawer drawer)
        {
            style.wordWrap = WordWrap;

            style.fontSize = FontSize;

            style.richText = RichText;
        }

        protected override void Draw(Drawer drawer)
        {
            float height = Height;

            if (height == 0f)
            {
                height = style.CalcHeight(label, drawer.DrawPosition.width);
            }

            drawer.DrawText(height, label, style);
        }

        #endif
    }
}