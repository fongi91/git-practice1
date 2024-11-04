// 3.1 기본 자료형

// 3.1.1 정수형 기본 타입(<-> 소수, 실수, 허수 ...)
// ex. 1, 2, -1 ... (0 = 정수 / 0.0은 정수x(실수))
// 데이터타입은 RAM 안에


// 1) sbyte (signed byte) 부호가 있는 8비트 정수 (-128~127) // 2의8승 bit     
// 2) byte (unsigned byte) 부호가 없는 8비트 정수 (0~255) --> 나이 등
// 3) short 부호가 있는 16비트(2바이트) 정수(-32768~32767)
// 4) ushort 부호가 없는 16비트 정수 (0~65535)
// 5) int 부호가 있는 32비트 정수(-21억~21억)
// 6) uint :부호가 없는 32비트(0~42억)
// 7) long : 부호가 있는 64비트 정수
// 8) ulong : 부호가 없는 64비트 정수 




namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //자료형 변수
        int n; 
        long sum; 

        int a = 100000000; // 32bit 정수형의 n이라는 변수명을 선언함과 동시에 10이라는 값을 RAM에 넣는다.
        long b = 100; // 64bit 정수형의 sum 이라는 변수명을 선언함과 동시에 100이라는 값을 RAM에 넣는다.

        int n1 = 50;
        int n2;
        n2 = 100;

        n = 5;
        sum = 50;

        sum = n1 + n2; // sum = 50+101;
        sum = 14; // 이전에 저장된 151이 지워짐. 14가 저장.



        Console.WriteLine(sum); // 출력결과 151

        // 기본타입에 대한 C#의 별칭
        // int -> System.Ini32
        // uint -> System.UInt32
        // ex.
        System.Int32 c1 = 10; // int c1 = 50 과 비슷
        System.Int32 c2 = 100;
        System.Int32 sum2 = c1 + c2;
        Console.WriteLine(sum2);

        
        // 실수형 기본타입

    }
}

