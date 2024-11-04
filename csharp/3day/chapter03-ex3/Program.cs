using System;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        /*// Console.ReadKey(); // ReadKey는 문자 한개만 입력 받음
        string input1 = Console.ReadLine(); // ReadLine은 입력을 string 형으로 받아 저장.
        Console.WriteLine("입력한 값 : " + input1);

        int number = int.Parse(input1); // input1 문자열을 숫자로 변형
        Console.WriteLine("입력한 값: " + number);*/


        // 문제: 계산기 기능 구현
        // 사용자로부터 두 숫자와 연산자(+, -, *, /)를 입력받아 계산 결과를 출력하는 switch문을 작성하세요.
        //   1. 먼저 두 숫자를 입력받은 후,
        //   2. 연산자는 Console.ReadKey()로 입력받아 처리합니다.

        // 예시 입력: 
        // 첫 번째 숫자: 10
        // 두 번째 숫자: 5
        // 연산자를 입력하세요 (+, -, *, /): +
        // 출력: 결과: 15

        Console.Write("첫번째 숫자 입력 :");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("두번째 숫자 입력 :");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("연산자 입력 : (+, -, *, /) ");
        ConsoleKeyInfo operationKey = Console.ReadKey();
        
        
        Console.WriteLine();

         switch (operationKey.KeyChar)
         {
             case '+': Console.WriteLine("덧셈 결과 : " + (num1 + num2)); break;
             case '-': Console.WriteLine("뺄셈 결과 : " + (num1 - num2)); break;
             case '*': Console.WriteLine("곱셈 결과 : " + (num1 * num2)); break;
             case '/':
                if (num2 == 0) Console.WriteLine("0으로 나눌 수 없습니다.");
                else Console.WriteLine("나눗셈 결과 : " + (num1 / num2));
                break;
                
             default: Console.WriteLine("잘못된 연산"); break;
         }


        /*Console.Write("첫번째 숫자 입력 :");
        int num3 = int.Parse(Console.ReadLine());
        Console.Write("두번째 숫자 입력 :");
        int num4 = int.Parse(Console.ReadLine());

        Console.WriteLine("연산자 입력 후 enter : (+, -, *, /) ");
        string operationKey1 = Console.ReadLine();

        if (operationKey1 == "+") Console.WriteLine(num3 + num4);
        else if (operationKey1 == "-") Console.WriteLine(num3 - num4);
        else if (operationKey1 == "*") Console.WriteLine(num3 * num4);
        else if (operationKey1 == "/") Console.WriteLine(num3 / num4);
        else Console.WriteLine("잘못된 연산");*/



  
    }
}

