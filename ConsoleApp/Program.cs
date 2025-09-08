
using System.Net.Http.Json;

// WebApi의 /cities 엔드포인트 URL (포트는 실제 실행 시 WebApi의 포트로 맞춰야 함)
var apiUrl = "http://localhost:5000/cities";

try
{
	using var httpClient = new HttpClient();
	var cities = await httpClient.GetFromJsonAsync<string[]>(apiUrl);
	if (cities != null)
	{
		Console.WriteLine("도시 리스트:");
		foreach (var city in cities)
		{
			Console.WriteLine("- " + city);
		}
	}
	else
	{
		Console.WriteLine("도시 정보를 받아오지 못했습니다.");
	}
}
catch (Exception ex)
{
	Console.WriteLine($"오류 발생: {ex.Message}");
}
