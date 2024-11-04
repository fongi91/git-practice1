// 형(type) 변환(conversion)
// 1. 암시적 형 변환
//    (1)
//    
// 2. 명시적 형 변환
namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //암시적 형 변환
        byte b = 250; // byte 범위 0~255
        short s = (short)b;  // short 범위 -32000~32000
        Console.WriteLine(s);

        short s1 = 25000;
        // byte b1 = s1; 암시적 형변환에서는 불가능함.

        
        //명시적 형변환
        byte b1 = (byte)s1;
        Console.WriteLine(b1); //가능은 하지만 25000이 줄여저서 나옴. 추천x


        ushort u = 65; // 0~65000

        char c = (char)u; // char은 담을 공간에 0000 ~ ffff(65,000) 까지임. (정수형 -> 문자형인 경우 명시적 형 변환만 허용)
        Console.WriteLine(c);


        // 문제1.
        byte byteValue = 10;
        char charValue = 'A';

        double doubleValue = byteValue; // 정수 - 실수 는 형변환 O 
        Console.WriteLine(doubleValue);

        // string str1 = charValue;   문자 - 문자열은 형변환 X


    }
}
