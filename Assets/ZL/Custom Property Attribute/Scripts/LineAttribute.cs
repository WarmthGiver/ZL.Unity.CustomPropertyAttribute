using UnityEngine;

namespace ZL.Unity
{
    public sealed class LineAttribute : CustomPropertyAttribute
    {
        private readonly Color color = Color.gray;

        public int Margin { get; set; } = defaultSpaceHeight;

        public int Thickness { get; set; } = 1;

        public LineAttribute(string hexColor = null)
        {
            if (ColorUtility.TryParseHtmlString(hexColor, out Color color) == true)
            {
                this.color = color;
            }
        }

        #if UNITY_EDITOR

        protected override void Draw(Drawer drawer)
        {
            drawer.DrawLine(Margin, Thickness, color);
        }

        #endif
    }
}