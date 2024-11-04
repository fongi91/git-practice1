// 문자형 기본타입
// 1. char : 유니코드 16bit 문자. 범위: U+0000 ~ U+FFFF  cf) 8비트(256가지 ASCII 코드)
// 범위 U+0000 // U+ = 유니코드, 0000 = 16진수
// 2. string : char 의 조합. 문자열


// boolean 기본타입
// 1. bool: true, false

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        char ch = 'A';  // '' quotation, " "double quotation
        string str = "A"; // double quotation
        string str2 = "school"; // double quotation


        Console.WriteLine(ch);
        Console.WriteLine(str);
        Console.WriteLine(str2);

        
        char ch1 = '\t'; // tab문자 표현
        char ch2 = 'T';
        char ch3 = '\n'; // 개행(new line) 문자를 표현. 한줄 띄우기
        char ch4 = 'o';

        Console.Write(ch1);
        Console.Write(ch2);
        Console.Write(ch3);
        Console.Write(ch4);

        Console.WriteLine(); //한줄띄우기 

        char ch5 = '\u25b6';
        char ch6 = '\u00ae';
        Console.WriteLine(ch5);
        Console.WriteLine(ch6);


        string sp1 = "▶";
        Console.WriteLine(sp1);


        char ch7 = '\\'; //문자로 인식하기위해
        Console.WriteLine(ch7);

        string str3 = "\\10,000";
        Console.WriteLine(str3); //\10000

        string str4 = "hello world";
        Console.WriteLine(str4);    //hello world

        string st5 = "\"hello world\"";
        Console.WriteLine(st5); //"hello world"

        string str6 = "\thello\tworld";
        Console.WriteLine(str6);   //    hello    world

        string str7 = @"\thello\tworld"; // @ 차이
        Console.WriteLine(str7); //\thello\tworld


        string str8 = "hello";
        Console.WriteLine(str8 + " " + "world"); //hello world


        bool bl1 = true;
        Console.WriteLine("bl1 값은 " + bl1); // bl1 값은 true

        // 정수 실수형은 ', " 붙이면 x



        string a = "100";
        string b = "100";
        Console.WriteLine(a + b);


    }
}