# [Custom Property Attribute] v1.1

🌍 [English](README.md) | [한국어](README_KOR.md)

Unity Inspector를 손쉽게 커스터마이징할 수 있는 CustomPropertyAttribute 컬렉션입니다.

## 📋 개요

이 에셋은 인스펙터를 손쉽게 커스텀할 수 있는 `CustomPropertyAttribute`들을 제공합니다. 인스펙터를 커스텀할 때마다 에디터 스크립트를 처음부터 작성해야 하는 번거로움을 해결하기 위해 제작되었습니다.

Unity에서 제공하는 `PropertyAttribute`와 `CustomPropertyDrawer`를 이용해 제작했으며, 하나의 필드에 `PropertyAttribute`를 여러 개 적용할 수 없는 `CustomPropertyDrawer`의 가장 큰 문제점을 개선하여 자유로운 인스펙터 커스텀이 가능합니다.

## ✨ 핵심 기술

### CustomPropertyAttribute

새로운 `CustomPropertyAttribute`를 만들기 위한 기본 클래스입니다.

### [UsingCustomProperty]

필드에 선언된 모든 `CustomPropertyAttribute`를 수집하여 한 번에 필드를 그립니다. 이를 통해 하나의 필드에 여러 개의 `PropertyAttribute`를 적용할 수 있는 문제를 해결합니다.

## 🚀 주요 기능

### [Alias]

필드에 별칭을 부여합니다. 매개변수로 ‘Null’을 지정하면 빈 라벨을 그립니다. ‘Empty("")’를 지정하면 라벨을 그리지 않습니다.

### [Button]

함수를 인스펙터에 버튼으로 표시합니다. 매개변수로 버튼의 텍스트와 높이를 지정할 수 있습니다.

### [ReadOnly]

필드 및 Attribute들을 읽기 전용으로 설정합니다.

### [ReadOnlyIf]
### [ReadOnlyIfPlayMode]

특정 필드의 값 비교, 어플리케이션이 실행중인지 아닌지 등 특정 조건에서만 읽기 전용으로 설정합니다.

### [Toggle]

해당 Attribute 하위에 선언된 필드 및 Attribute들을 비활성화시킵니다. 특정 필드의 상태 비교로 특정 조건에서만 비활성화하는 것도 가능합니다.

### [Essetial]

필드의 값이 'Null' 또는 'Empty(“”)' 일 때 경고 메시지를 표시합니다.

### [PropertyField]

필드를 다른 Attribute보다 먼저 그립니다.

### [LabelField]

필드의 라벨만 따로 그립니다.

### [LayerField]

‘int’ 타입 필드를 ‘Layer’ 드롭다운 메뉴로 표시합니다.

### [TagField]

‘string’ 타입 필드를 ‘Tag’ 드롭다운 메뉴로 표시합니다.

### [GetComponent]
### [GetComponentInParent]
### [GetComponentInParentOnly]
### [GetComponentInChildren]
### [GetComponentInChildrenOnly]

‘Component’ 타입 필드에 해당 타입의 컴포넌트를 각 범위 내에서 찾아서 할당합니다.

### [MessageBox]
### [InfoBox]
### [WarningBox]
### [ErrorBox]

각자 해당하는 아이콘과 함께 메시지 박스를 그립니다

### [AddIndent]

필드를 지정한 값만큼 들여 씁니다.

### [SetIndent]

필드의 들여 쓴 정도를 지정합니다.

### [Line]

구분선을 그립니다. 매개변수로 선의 색상과 굵기를 지정할 수 있습니다.

### [Margin]

여백을 그립니다. 매개변수로 여백의 높이를 지정할 수 있습니다.

### [Preview]

Texture, Sprite, GameObject, Material 등 이미지가 존재하는 ‘Object’ 타입 필드의 미리 보기를 그립니다.

### [Text]

텍스트를 그립니다. 매개변수로 텍스트의 색상과 정렬 위치, 스타일, 폰트 크기를 지정할 수 있습니다.

### [Require]

필수적인 Component를 자동 추가 및 할당합니다.

## 🛠️ 설치 방법

1. Unity Package Manager를 통해 설치하거나
2. 프로젝트의 Assets 폴더에 직접 파일들을 복사합니다

## 👨‍💻 개발자

**이시온 (ZION LEE)**
- 📧 Email: warmth.giver@gmail.com

## ⭐ 지원

이 프로젝트가 도움이 되었다면 ⭐을 눌러주세요!
