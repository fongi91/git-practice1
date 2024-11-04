namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // 증감 연산자(++, --)
        // ++ : 피연산자의 값을 1 증가시킨다.
        // -- : 피연산자의 값을 1 감소시킨다.
        // 작업 간 순차적인 count 필요.
        int n = 50;
        n++; // n = n+1;
        Console.WriteLine(n);

        n--; // n = n-1;
        Console.WriteLine(n);

        ++n; // n = n+1;
        Console.WriteLine(n);

        --n; // n = n-1
        Console.WriteLine(n+"\n\n---------------------");
        //증감연산자 실행순서 파악
        int n2 = 50;
        Console.WriteLine(n2++); // 콘솔 출력 후 증가 50
        Console.WriteLine(n2++); // 51 
        Console.WriteLine(n2);   // 52
        Console.WriteLine("-----------------------");
        int n3 = 50;
        Console.WriteLine(n3++); // 50
        Console.WriteLine(++n3); // 증가 후 콘솔 출력 52
        Console.WriteLine(n3); // 52
        Console.WriteLine("-----------------------");
        
        n = 50;
        int result;
        result = n++;  // 1.result=n(50)   2.n=n+1
        Console.WriteLine(result);

        n = 50;
        result = ++n; // 1.n=n+1  2.result=n(51)
        Console.WriteLine(result);

        n = 50;
        result = n--; // 1.result=n(50)   2.n=n-1
        Console.WriteLine(result);

        n = 50;
        result = --n; // 1.n=n-1  2.result=n(49)
        Console.WriteLine(result);


    }
}