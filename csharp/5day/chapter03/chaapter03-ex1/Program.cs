
namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //for문을 이용해서 1부터 n까지의 합을 구하기
        //    Q: 사용자로부터 양의 정수 n을 입력받고, 1부터 n까지의 합을 구하여 출력하세요.
        //       단일 for문을 사용하여 계산합니다.




        //Console.WriteLine("n의 값을 입력하세요:");
        //int n = int.Parse(Console.ReadLine());
        //int sum = 0;

        //// 코드작성
        //for(int i = 1; i <= n; i++)
        //{
        //    sum = sum + i;
        //}
        //Console.WriteLine(sum);

        int sum;
        // 구구단 출력(5단)
        int number = 5;
        int j = 1;
        for(j = 1; j <= 9; j++)
        {
            Console.WriteLine($"{number} * {j} = {number * j}");
        }

        // 배열의 요소 합 구하기
        // numbers 배열의 모든 요소의 합을 구하여 출력
        // 단일 for 문 사용

        int[] numbers = { 3, 5, 7, 9, 11, 13 };
        sum = 0;
        
        for(int i = 0; i < numbers.Length; i++)
        {
            sum = sum + numbers[i];
        }
        Console.WriteLine($"모든 요소의 합 : {sum}");


        // 

    }
}
