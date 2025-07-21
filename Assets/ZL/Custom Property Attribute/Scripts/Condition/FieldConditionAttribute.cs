#if UNITY_EDITOR

using UnityEditor;

#endif

namespace ZL.Unity
{
    public abstract class FieldConditionAttribute : CustomPropertyAttribute
    {
        private readonly string fieldName;

        protected readonly object targetValue;

        protected readonly bool condition;

        public FieldConditionAttribute(string fieldName, bool targetValue) : this(fieldName, targetValue, true) { }

        public FieldConditionAttribute(string fieldName, object targetValue, bool condition)
        {
            this.fieldName = fieldName;

            if (targetValue?.GetType().IsEnum == true)
            {
                this.targetValue = (int)targetValue;
            }

            else
            {
                this.targetValue = targetValue;
            }

            this.condition = condition;
        }

        #if UNITY_EDITOR

        protected SerializedProperty property = null;

        protected override void Initialize(Drawer drawer)
        {
            if (drawer.Property.TryFindProperty(fieldName, out var property) == true)
            {
                this.property = property;
            }
        }

        protected override void Draw(Drawer drawer)
        {
            if (property == null)
            {
                drawer.DrawErrorBox($"{AttributeNameTag} No property found matching \"{fieldName}\".");

                return;
            }

            SetCondition(drawer);
        }

        protected abstract void SetCondition(Drawer drawer);

        #endif
    }
}