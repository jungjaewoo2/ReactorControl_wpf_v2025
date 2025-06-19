# ReactorControl WPF 프로젝트

원자로 제어 시스템을 위한 WPF 기반의 사용자 인터페이스 프로젝트입니다.

## 프로젝트 구조

```
ReactorControl_wpf_v2025/
├── App.xaml / App.xaml.cs     # 애플리케이션 진입점
├── MainWindow.xaml / .cs      # 메인 윈도우 UI 및 로직
├── Classes/                   # 유틸리티 클래스
├── Models/                    # 데이터 모델
├── View/                      # UI 컴포넌트
│   ├── UC_CAR.xaml           # CAR 관련 컨트롤
│   ├── UC_PC_ADS1.xaml       # ADS(Active Drainage System) 컨트롤
│   ├── UC_ProcessControl     # 프로세스 제어 메인 화면
│   ├── UC_RxPowerControl     # 원자로 전원 제어
│   └── UC_SSR.xaml           # SSR 관련 컨트롤
└── ProcessValue/             # 프로세스 값 처리 및 표시 컴포넌트
    ├── AlarmViewer          # 알람 표시
    ├── BarChartA            # 차트 컴포넌트
    ├── MenuMainButton       # 메인 메뉴 버튼
    ├── PDBControl          # 프로세스 데이터베이스 제어
    └── TrendChart          # 트렌드 차트 컴포넌트

## 주요 기능

1. 프로세스 제어 (Process Control)
   - Active Drainage System (ADS) 제어
   - 펌프 상태 모니터링 및 제어
   - 프로세스 파라미터 표시 및 조정

2. 원자로 전원 제어 (Reactor Power Control)
   - 전원 상태 모니터링
   - 안전 시스템 연동
   - 경보 시스템

3. 데이터 시각화
   - 실시간 트렌드 차트
   - 바 차트
   - 알람 뷰어

4. 시스템 통합
   - 서버 통신
   - 프로세스 데이터베이스 연동
   - 이벤트 로깅

## 기술 스택

- .NET Framework 4.0+
- WPF (Windows Presentation Foundation)
- XAML
- C#

## 시스템 요구사항

- Windows 운영체제
- .NET Framework 4.0 이상
- 최소 해상도: 1920 x 1080

## 라이브러리 의존성

- LibCommunication.dll
- LibHistorian.dll
- LibUtility.dll
- MySqlConnector.dll
- PDBLib.dll
- ProcessValue.dll

## 개발 환경 설정

1. Visual Studio 설치
2. 필요한 NuGet 패키지 설치
3. 프로젝트 빌드
4. 필요한 DLL 파일들이 bin 디렉토리에 있는지 확인

## 빌드 및 실행

1. Visual Studio에서 솔루션 파일 열기
2. 솔루션 빌드
3. ReactorControl.exe 실행

## 주의사항

- 화면 해상도는 1920x1080을 기준으로 설계되었습니다.
- 프로세스 제어 시스템의 특성상 안전에 유의해야 합니다.
- 서버 연결 상태를 항상 확인해야 합니다. 