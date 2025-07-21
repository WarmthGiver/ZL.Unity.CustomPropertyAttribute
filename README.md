# Custom Property Attribute

🌍 [English](README.md) | [한국어](README_KOR.md)

A collection of CustomPropertyAttribute that allows easy customization of Unity Inspector.

## 📋 Overview

This asset provides `CustomPropertyAttributes` that allow you to easily customize inspectors. It was created to eliminate the hassle of having to write editor scripts from scratch every time you customize an inspector.

We built this using Unity's `PropertyAttribute` and `CustomPropertyDrawer` and improved the biggest issue with `CustomPropertyDrawer` which doesn't allow multiple `PropertyAttribute's to be applied to a single field to enable free inspector customization.

## ✨ Key Technology

### CustomPropertyAttribute
The base class for creating new `CustomPropertyAttribute`.

- **Initialize**: Initializes the attribute
- **Preset**: Sets the state of the field
- **Draw**: Draws the field

### UsingCustomProperty
Collects all `CustomPropertyAttribute` declared in the field and draws the fields at once. This solves the problem of applying multiple `PropertyAttribute` to a single field.

## 🚀 Features

### Field Customization
- **[Alias]**: Assign aliases to fields
- **[ReadOnly]**: Set fields as read-only
- **[ReadOnlyIfPlayMode]**: Set as read-only only under specific conditions
- **[ReadOnlyIf]**: Conditional read-only based on field value comparison
- **[Toggle]**: Disable fields and attributes

### UI Elements
- **[Button]**: Display functions as buttons in the inspector
- **[Preview]**: Display preview of image objects
- **[Text]**: Draw custom text (color, alignment, style, font size configurable)

### Validation & Warnings
- **[Essential]**: Display warning messages when Object type fields are null or string fields are empty
- **[ErrorBox]**: Display error message boxes
- **[WarningBox]**: Display warning message boxes
- **[InfoBox]**: Display info message boxes
- **[MessageBox]**: Display general message boxes

### Auto Assignment
- **[GetComponent]**: Automatically find and assign components of the corresponding type
- **[GetComponentInChildren]**: Find and assign components in child objects
- **[GetComponentInChildrenOnly]**: Find and assign components only in child objects
- **[GetComponentInParent]**: Find and assign components in parent objects
- **[GetComponentInParentOnly]**: Find and assign components only in parent objects

### Field Type Conversion
- **[LayerField]**: Display int type fields as Layer dropdown
- **[TagField]**: Display string type fields as Tag dropdown
- **[LabelField]**: Draw only the field labels
- **[PropertyField]**: Draw fields before other attributes

### Layout & Styling
- **[AddIndent]**: Indent fields by specified value
- **[SetIndent]**: Specify the indentation position of fields
- **[Line]**: Draw dividing lines (color and thickness configurable)
- **[Margin]**: Draw margins (height configurable)

## 🛠️ Installation

1. Install via Unity Package Manager, or
2. Copy files directly to your project's Assets folder

## 📖 Usage

```csharp
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    [Alias("Custom Name")]
    [ReadOnly]
    public string readOnlyField = "This is read only";
    
    [Button("Test Button", 30)]
    public void TestMethod()
    {
        Debug.Log("Button clicked!");
    }
    
    [Essential]
    [Preview]
    public Sprite spriteField;
    
    [LayerField]
    public int layerIndex;
    
    [TagField] 
    public string tagName;
    
    [GetComponent]
    public Rigidbody rigidBody;
}
```

## 📋 Requirements

- Unity 2019.4 or higher
- .NET Framework 4.x

## 👨‍💻 Developer

**ZION LEE**
- 📧 Email: warmth.giver@gmail.com
- 📱 Phone: 010-7725-1342

## 📄 License

Please contact for license information.

## 🤝 Contributing

If you want to contribute to this project:

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## ⭐ Support

If this project helped you, please give it a ⭐!

---

*Make Unity Inspector customization easier and more efficient with Custom Property Attribute!*
