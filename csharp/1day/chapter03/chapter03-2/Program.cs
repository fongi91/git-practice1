//실수형 기본 타입
// 1) float -> 4바이트(2의32승)
// 2) double -> 8바이트(2의64승)
// 3) decimal -> 16바이트(2의128승)


namespace ConsoleApp1;

class Program // collapse(펼치다), uncollapse(접다)
{
    static void Main(string[] args)
    {
        float f = 5.2f; // 기본적으로 소수점은 double을 가리킴. float으로 사용하려면 마지막에 f를 추가
        double d = 10.5;
        decimal money = 200.0999m; // decimal은 마지막에 m를 추가

        Console.WriteLine(f);
        Console.WriteLine(d);
        Console.WriteLine(money);

        Console.WriteLine();
        Console.WriteLine();


        // 문제1. 변수선언, 올바르게 초기화
        ushort age = 25; // ushort 으로 해줘야 나이임을 추측 가능
        float height = 175.5f;
        Console.WriteLine(age);
        Console.WriteLine(height);


        // 문제2. 오류 수정
        // byte num = 300;
        short num = 300;
        // int result = num + 100.5;
        double result = num + 100.5;
        Console.WriteLine(result);
   





    }
}