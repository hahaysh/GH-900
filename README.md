# GH-900

GH-900 수업 데모용

## 프로젝트 구조

```
GH-900/
├── WebApi/        # 10개 도시 리스트를 JSON으로 반환하는 ASP.NET Core Minimal API
│   └── Program.cs # /cities 엔드포인트에서 도시 리스트 반환
├── ConsoleApp/    # WebApi의 /cities 엔드포인트에서 도시 리스트를 받아 콘솔에 출력하는 .NET 콘솔 앱
│   └── Program.cs # API 호출 및 결과 출력 샘플 코드
├── LICENSE
├── README.md
```

### WebApi
- `/cities` 엔드포인트에서 아래와 같은 10개 도시 리스트를 JSON 배열로 반환합니다.
	- Seoul, Busan, Incheon, Daegu, Daejeon, Gwangju, Suwon, Ulsan, Changwon, Goyang

### ConsoleApp
- WebApi의 `/cities` 엔드포인트를 호출하여 도시 리스트를 받아 콘솔에 출력합니다.

test
