using System;

namespace ConsoleApp1;

class Program
{
    // 문제 : FizzBuzz 출력
    // 1~50 숫자 출력하되, 3의배수일 경우 "Fizz" 출력
    // 3과5의 공배수 일 경우 "FizzBuzz" 출력 (3과 5의 공배수는 15의배수) // 3으로 나눠도 0 && 5로 나눠도 0
    // 나머지 숫자는 그대로 출력
    // for, if문 이용
    static void Main(string[] args)
    {
        //1. 1~50 숫자를 출력
        int i;

        for(i = 1; i<51 ; i++)
        {
            //3의 배수일 경우 Fizz 출력, 5의 배수일 경우 Buzz 출력
            if ((i % 3 == 0) && i % 5 == 0)
            {
                string st1 = i.ToString();
                st1 = "FizzBuzz";
                Console.WriteLine(st1);
            }
            else if(i % 3 == 0)
            {
                string st2 = i.ToString();
                st2 = "Fizz";
                Console.WriteLine(st2);
            }
            else if(i % 5 == 0)
            {
                string st3 = i.ToString();
                st3 = "Buzz";
                Console.WriteLine(st3);
            }
            else
            Console.WriteLine(i);
        }


        for (i = 1; i < 51; i++)
        {
            //3의 배수일 경우 Fizz 출력, 5의 배수일 경우 Buzz 출력, 공배수인경우 FizzBuzz 출력
            if ((i % 3 == 0) && i % 5 == 0) Console.WriteLine("FizzBuzz"); // 순서를 어떻게 정하냐가 중요!
            else if (i % 3 == 0) Console.WriteLine("Fizz");
            else if (i % 5 == 0) Console.WriteLine("Buzz");
            else Console.WriteLine(i);
        }

    }
}
