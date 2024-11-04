using System.Runtime.InteropServices;

namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        /*        // 중첩 루프(다중 for문)
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("i: " + i + " -> ");   // 0 -> 
                    Console.Write("j: ");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(j + " "); // 0 1 2 
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                // 구 구 단
                for (int x = 2; x < 10; x++)
                {
                    for (int y = 1; y < 10; y++)
                    {
                        Console.WriteLine($"{x} * {y} = {x * y}");
                    }
                    Console.WriteLine();
                }

                // 구구단이 가로로 나오게 
                for (int y = 1; y < 10; y++)
                {
                    for (int x = 2; x < 10; x++)
                    {
                        Console.Write($"{x}*{y} = {x * y}, \t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\n\n\n");

                // 정사각형 별 패턴
                //   Q. 사용자가 입력한 숫자 n을 기준으로 n x n 정사각형의 별 패턴을 출력하세요.
                //      이중 for문을 사용하여 별을 출력하세요.
                // ****
                // ****
                // ****
                // ****
                while(true)
                { 
                    Console.WriteLine("정사각형의 크기를 입력하시오");
                    int insert = int.Parse(Console.ReadLine());

                    for (int i = 0; i < insert; i++)
                    {
                        for(int j = 0; j < insert; j++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                }
        */
        
        
        Console.WriteLine("숫자를 입력하시오");
        int insert = int.Parse(Console.ReadLine());
        for (int i = 1; i <= insert; i++)
        {
            for(int j = 1; j <= insert; j++)
            {
                Console.Write($"{i} + {j} = {i + j}\t");
            }
            Console.WriteLine();
        }



        for(int i = 0; i < 5; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
                
        }
    }
}
