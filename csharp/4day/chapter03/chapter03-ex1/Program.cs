using System;

namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        // 문제: 비밀번호 맞추기 문제
        //   Q. 사용자로부터 비밀번호를 입력받고, 비밀번호가 맞을 때까지 계속 입력을 요청하는
        //      프로그램을 작성하세요. 비밀번호가 맞으면 "비밀번호가 올바릅니다"를 출력하고 종료합니다.
        //      정답 비밀번호는 "password123"입니다.

        // 예시: 비밀번호를 입력하세요: abc
        //       비밀번호가 틀렸습니다. 다시 시도하세요.
        //       비밀번호를 입력하세요: 24fd
        //       비밀번호가 틀렸습니다. 다시 시도하세요.
        //       비밀번호를 입력하세요: password123
        //       비밀번호가 올바릅니다   
        // 프로그램 종료

        
        string correctPassword = "password123";
        string userInput = "";
        do
        {
            // 1. 출력
            Console.Write("비밀번호를 입력하세요: ");
            // 2. 입력값 받기
            userInput = Console.ReadLine();
            // 3. 비교(true이면 올바르다 출력, false이면 틀렸다. 다시시도 출력)
            if (userInput==correctPassword) Console.WriteLine("비밀번호가 올바릅니다.");
            else Console.WriteLine("비밀번호가 틀렸습니다. 다시 시도하세요.");
        } while (correctPassword != userInput);

        

        // 문제: 사용자로부터 양의 정수 n을 입력받고, 1부터 n까지의 모든 홀수를 출력하는
        //       프로그램을 while문을 사용하여 작성하세요.
        Console.WriteLine("양의정수 입력");
        int input_n = int.Parse(Console.ReadLine());
        int n = 1;
        while(n<=input_n)
        {
            if (n % 2 == 1) // 2로 나누었을때 나머지가 1이면 홀수
                Console.WriteLine($"{n}");
            n++;
        }
        
    }
}
