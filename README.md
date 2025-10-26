# Sioat.Preview

**[Sioat (시옷)](https://github.com/sions/Sioat)** 프로젝트의 공개 벤치마크 테스트 리포지토리

## 프로젝트 소개

이 리포지토리는 Sioat의 IL 최적화 엔진이 실제로 어떤 성능 향상을 제공하는지 검증하기 위한 벤치마크 테스트 모음입니다.

Sioat는 .NET IL 코드를 자동으로 최적화하여 성능을 향상시키는 프레임워크입니다. 이 프로젝트는 다양한 최적화 수준에서의 성능을 비교할 수 있는 테스트 케이스들을 제공합니다.

---

## 테스트 코드 구조

### 파일 명명 규칙

테스트 코드는 다음과 같은 명명 규칙을 따릅니다:

#### 1. `{TestName}_Full.cs`
- **최적화 비활성화 버전** (기준선)
- `[DontOptimize]` 속성이 적용되어 Sioat 최적화를 회피
- 원본 C# 코드의 순수한 성능을 측정
- 다른 버전들과 비교하기 위한 기준점

**예시:**
```csharp
[Test("List Foreach")]
[DontOptimize]  // 최적화 회피
public void List_Foreach()
{
    int ct = 0;
    foreach (var player in list)
    {
        ct += player.no;
    }
    result = ct;
}
```

#### 2. `{TestName}_Optimize.cs`
- **기본 최적화 버전**
- `[DontOptimize]` 속성만 제거
- Sioat의 표준 최적화가 적용됨
- 안전성과 성능의 균형을 제공

#### 3. `{TestName}_Optimize_Fast.cs`
- **고급 최적화 버전**
- 추가 최적화 옵션이 활성화됨
- 더 공격적인 최적화를 통해 최대 성능 추구
- 특정 시나리오에서 안정성보다 성능을 우선시

### 현재 테스트 케이스

```
src/
├── Foreach_Full.cs                    # 기준선: List/Array Foreach 반복문
├── Foreach_Full_Optimize.cs           # 기본 최적화
├── Foreach_Full_Optimize_Fast.cs      # 고급 최적화
├── Foreach_Full_Struct.cs             # 기준선: Struct 기반 Foreach
├── Foreach_Full_Struct_Optimize.cs    # Struct 기본 최적화
└── Foreach_Full_Struct_Optimize_Fast.cs # Struct 고급 최적화
```

---

## 웹 벤치마크 데모

실제 성능 비교를 웹 브라우저에서 직접 확인할 수 있습니다:

🌐 **[https://sioatbenchmark.pages.dev/](https://sioatbenchmark.pages.dev/)**

---

## 빌드 결과물

이 리포지토리에는 다양한 플랫폼에서의 벤치마크 결과를 확인할 수 있도록 사전 빌드된 패키지가 포함되어 있습니다:

### Unity 6.2 빌드

- **Android APK**: `unity6.2_android.apk` (9.8 MB)
  - Android 디바이스에서 직접 설치하여 네이티브 성능 측정

- **Android Bundle**: `unity6.2_android.zip` (9.6 MB)
  - 압축된 Android 빌드 패키지

- **WebAssembly**: `unity6.2_web_wasm.zip` (3.4 MB)
  - 웹 브라우저에서 실행 가능한 WASM 빌드
  - [데모 사이트](https://sioatbenchmark.pages.dev/)에서 사용됨

- **Windows IL2CPP**: `unity6.2_windows_il2cpp.zip` (23.2 MB)
  - Windows 네이티브 빌드 (IL2CPP 백엔드)
  - 최고 성능의 데스크톱 벤치마크

---

## 성능 비교 예시

각 테스트는 동일한 작업을 수행하며, 최적화 수준에 따른 성능 차이를 측정합니다:

| 버전 | 설명 | 예상 성능 |
|------|------|-----------|
| `_Full` | 최적화 없음 (기준선) | x1.0 (기준) |
| `_Optimize` | 기본 최적화 | x10 ~ x20 |
| `_Optimize_Fast` | 고급 최적화 | x15 ~ x30 |

> 실제 성능 향상은 테스트 케이스와 실행 환경에 따라 다를 수 있습니다.

---

## Sioat 프로젝트 정보

Sioat에 대한 더 자세한 정보는 메인 리포지토리를 참조하세요:

📦 **[github.com/sions/Sioat](https://github.com/sions/Sioat)**

### 주요 기능
- List Foreach 최적화
- System.Runtime.CompilerServices.Unsafe 자동 적용
- 메서드 내부 static 변수 최적화
- Enum 최적화
- 그 외 다양한 성능 최적화 기능

### 지원 플랫폼
- **Unity3D**: 2022.3 이상 (Mono, IL2CPP) (2021, 6.2 에서도 테스트 완료)
- **.NET 6.0+**: Debug, Release 빌드

---

## 라이선스

상용 라이센스 (Sioat 메인 프로젝트 참조)
