# Custom Property Attribute

🌍 [English](README_ENG.md) | [한국어](README_KOR.md)

Unity Inspector를 손쉽게 커스터마이징할 수 있는 CustomPropertyAttribute 컬렉션입니다.

## 📋 개요

이 에셋은 인스펙터를 손쉽게 커스텀할 수 있는 `CustomPropertyAttribute`들을 제공합니다. 인스펙터를 커스텀할 때마다 에디터 스크립트를 처음부터 작성해야 하는 번거로움을 해결하기 위해 제작되었습니다.

Unity에서 제공하는 `PropertyAttribute`와 `CustomPropertyDrawer`를 이용해 제작했으며, 하나의 필드에 `PropertyAttribute`를 여러 개 적용할 수 없는 `CustomPropertyDrawer`의 가장 큰 문제점을 개선하여 자유로운 인스펙터 커스텀이 가능합니다.

## ✨ 핵심 기술

### CustomPropertyAttribute
새로운 `CustomPropertyAttribute`를 만들기 위한 기본 클래스입니다.

- **Initialize**: Attribute를 초기화합니다
- **Preset**: 필드의 상태를 설정합니다
- **Draw**: 필드를 그립니다

### UsingCustomProperty
필드에 선언된 모든 `CustomPropertyAttribute`를 수집하여 한 번에 필드를 그립니다. 이를 통해 하나의 필드에 여러 개의 `PropertyAttribute`를 적용할 수 있는 문제를 해결합니다.

## 🚀 주요 기능

### 필드 커스터마이징
- **[Alias]**: 필드에 별칭을 부여합니다
- **[ReadOnly]**: 필드를 읽기 전용으로 설정합니다
- **[ReadOnlyIfPlayMode]**: 특정 조건에서만 읽기 전용으로 설정합니다
- **[ReadOnlyIf]**: 특정 필드 값 비교를 통한 조건부 읽기 전용 설정
- **[Toggle]**: 필드 및 Attribute를 비활성화합니다

### UI 요소
- **[Button]**: 함수를 인스펙터에 버튼으로 표시합니다
- **[Preview]**: 이미지 오브젝트의 미리보기를 표시합니다
- **[Text]**: 커스텀 텍스트를 그립니다 (색상, 정렬, 스타일, 폰트 크기 지정 가능)

### 검증 및 경고
- **[Essential]**: Object 타입 필드가 null이거나 string 필드가 비어있을 때 경고 메시지를 표시합니다
- **[ErrorBox]**: 오류 메시지 박스를 표시합니다
- **[WarningBox]**: 경고 메시지 박스를 표시합니다
- **[InfoBox]**: 정보 메시지 박스를 표시합니다
- **[MessageBox]**: 일반 메시지 박스를 표시합니다

### 자동 할당
- **[GetComponent]**: 해당 타입의 컴포넌트를 자동으로 찾아서 할당합니다
- **[GetComponentInChildren]**: 자식 오브젝트에서 컴포넌트를 찾아 할당합니다
- **[GetComponentInChildrenOnly]**: 자식 오브젝트에서만 컴포넌트를 찾아 할당합니다
- **[GetComponentInParent]**: 부모 오브젝트에서 컴포넌트를 찾아 할당합니다
- **[GetComponentInParentOnly]**: 부모 오브젝트에서만 컴포넌트를 찾아 할당합니다

### 필드 타입 변환
- **[LayerField]**: int 타입 필드를 Layer 드롭다운으로 표시합니다
- **[TagField]**: string 타입 필드를 Tag 드롭다운으로 표시합니다
- **[LabelField]**: 필드의 라벨만 따로 그립니다
- **[PropertyField]**: 필드를 다른 Attribute보다 먼저 그립니다

### 레이아웃 및 스타일링
- **[AddIndent]**: 필드를 지정한 값만큼 들여쓰기합니다
- **[SetIndent]**: 필드의 들여쓰기 위치를 지정합니다
- **[Line]**: 구분선을 그립니다 (색상과 굵기 지정 가능)
- **[Margin]**: 여백을 그립니다 (높이 지정 가능)

## 🛠️ 설치 방법

1. Unity Package Manager를 통해 설치하거나
2. 프로젝트의 Assets 폴더에 직접 파일들을 복사합니다

## 📖 사용법

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

## 📋 요구사항

- Unity 2019.4 이상
- .NET Framework 4.x

## 👨‍💻 개발자

**이시온 (ZION LEE)**
- 📧 Email: warmth.giver@gmail.com
- 📱 Phone: 010-7725-1342

## 📄 라이센스

이 프로젝트의 라이센스 정보는 별도로 문의해주세요.

## 🤝 기여하기

이 프로젝트에 기여하고 싶으시다면:

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## ⭐ 지원

이 프로젝트가 도움이 되었다면 ⭐을 눌러주세요!

---

*Unity Inspector 커스터마이징을 더욱 쉽고 효율적으로 만들어주는 Custom Property Attribute를 사용해보세요!*