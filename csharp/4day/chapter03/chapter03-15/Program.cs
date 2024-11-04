namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        //break문: 블록 내 1개의 while문을 빠져나감
        int i = 2;
        while (true)
        {
            int j = 1;
            while (true)
            {
                Console.WriteLine($"{i} * {j} = {i * j}");
                j++;
                if (j > 9)
                    break;
            }
            if (++i > 9)
                break;
        }

        // continue : 블록 내 1개의 while 조건문으로 이동
        int sum = 0;
        int n = 1;

        while (n++ <= 1000)
        {

            Console.WriteLine($"n은 {n}");
            if (n % 2 != 0)
            {
                continue;
            }
            sum += n;

        }
        Console.WriteLine(sum);
        Console.WriteLine("\n\n\n\n\n\n");


        n = 0;
        sum = 0;
        while (++n < 200)
        {
            
            if ((n % 2) != 0) continue;
            if ((n % 3) != 0) continue;
            if ((n % 5) != 0) continue;
            sum += n;
            Console.WriteLine(n);
        }
        Console.WriteLine($"{n}까지의 수 중 2의배수이며 3의배수이며 5의배수인 수의 합은{sum} ");
    }
    
}