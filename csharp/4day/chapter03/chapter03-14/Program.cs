
namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //반복문(while, for) -> 중요...!
        //while (조건식)
        //   구문;
        // while (조건식) 구문;
        // cf) if문과 비슷. 1개 이상의 구문을 실행하려면 중괄호{} 를 사용


        //1~1000을 더하는 while문
        int sum = 0;
        int n = 1;
        while (n <= 1000)
        {
            sum += n;
            Console.WriteLine(n+" : "+sum);
            n++;

        }
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine(sum);

        //1~1000까지 짝수만 더하는 while문
        sum = 0;
        n = 1;
        while (n <= 1000)
        {
            if (n % 2 == 0)
            {
                sum += n;
                Console.WriteLine($"{n}번째 : {sum}");
            }
            n++;
        }
        Console.WriteLine(sum);
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("-------------------------------------------");



        // do~while 문 : do문이 1번은 실행되는 while문
        /*do
        {
            구문1;
            구문2;
        } while (조건식);
*/
        sum = 0;
        n = 0;
        do
        {
            if (n % 2 == 0)
                sum += n;
        } while (++n <= 1000);

        sum = 0;
        n = 100;
        do
        {
            Console.WriteLine($"sum은 {sum}");
            if (n % 2 == 0)
                sum += n;
        } while (++n <= 1000);








    }
}

