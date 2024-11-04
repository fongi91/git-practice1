namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // 제어문 중의 반복문인 for, foreach
        // for문 문법
        //   for(초기화; 조건식; 반복식) 
        //     구문;
        //
        //   중괄호 사용은 구문이 1개이상일 경우 사용
        //
        //   for(초기화; 조건식; 반복식) 구문;
        int n;
        for (n = 1; n <= 9; n++)
        {
            Console.WriteLine(n);

        }
        // 실행순서 
        //   1. n = 1    cf) 한번만 실행
        //   2. n <= 9 true이면
        //   3. Console.WriteLine(n);
        //   4. n++
        //   5. n <= 9 true이면
        //   6. Console.WriteLine(n);
        //   7. n++
        //   8. n <= 9 true이면
        //   9. Console.WriteLine(n);
        //      .
        //      .
        //   만약 false이면 for문을 나간다.

        for (int a = 1; a <= 9; a++)
        {
            Console.WriteLine(a);
        }
        // for문의 초기화, 조건문, 반복식은 생략 가능
        for(;n<=9;n++)
        {
            Console.WriteLine("n"); // n이 10이기때문에 실행 x
        }

        for(; ;n++)  //조건이 없으면 무한반복
        {
            if (n > 9) break; // 9이상이면 for문을 나간다. 
        }

        // 초기화와 조건문과 반복식이 생략
        for(; ; ) // while(true) 와 같다.
        {

        }

    }
}