namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // 제어문(Control Statement)
        // 0. 관계 및 논리연산자
        //   - 관계연산자: >, >=, <=, <, ==, !=
        //   - 논리연산자: &&, ||, !

        bool result1 = (10 > 20);
        Console.WriteLine(result1); // False

        bool result2 = (10 < 20);
        Console.WriteLine(result2 + "\n"); // True

        int value1 = 6;
        int n1 = value1 % 3; // n1은 0
        bool result3 = (n1 != 0);
        Console.WriteLine(result3);
        Console.WriteLine();
        Console.WriteLine();


        //   - 논리연산자: &&(and), ||(or), !(not) 
        // ex) A AND(&&) B : AND연산자는 A와 B의 논리값이 하나라도 False 이면 결과는 False
        // ex) A OR(||) B : OR연산자는 A와 B의 논리값이 하나라도 True 이면 결과는 True
        int value2 = 10;
        int n3 = value2 % 3; // 1
        int n4 = value2 % 5; // 0

        bool orResult1 = (n3 == 0 || n4 == 0); // false || true -> true
        Console.WriteLine("value는 3의배수이거나 5의배수이면 " + orResult1 + "이다."); // True

        bool andResult1 = (n3 == 0 && n4 == 0); // false && true -> false
        Console.WriteLine("value는 3의배수이면서 5의배수이면 " + andResult1 + "이다."); // False

        bool notResult1 = !(n3 == 0);
        Console.WriteLine("value는 3의배수가 아님: " + notResult1);


        int n11 = 6;
        int n12 = 10;
        bool result11 = (n11 % 3 == 0 || n12 % 3 == 0); //6은 3의배수이거나 10은 3의배수이면 true
        Console.WriteLine("n11 또는 n12는 3의 배수? ->  " + result11);

        bool result12 = (n11 % 3 == 0 && n12 % 3 == 0); //6은 3의배수이고 10은 3의배수이면 true
        Console.WriteLine("n11이 3의 배수이고 n12는 3의 배수? ->  " + result12);



        Console.WriteLine("\n\n\n\n\n\n\n\n");


        //문제1. 조건을 만족하는 논리연산을 사용하여 맞으면 true / 틀리면 false
        //조건 : 변수 age>=70 이고, hasLicense가 true 일 경우 true / 틀리면 false
        int age = 40;
        bool hasLicense = true;
        bool result13 = (age >= 70 && hasLicense);
        Console.WriteLine("문제1의 결과 : " + result13);


        //문제2. isweekend와 isHoliday 중 하나라도 true 일 경우 true 를 출력. 아니면 false
        bool isWeekend = false;
        bool isHoliday = true;
        bool result14 = (isWeekend || isHoliday);
        Console.WriteLine("문제2의 결과 : " + result14);


        //문제3. 아래 변수를 사용하여 조건을 만족할 때 true 아니면 false 출력
        // temperature 20 이상 30 이하
        // isRainy
        int temperature = 25;
        bool isRainy = false;

        bool result15 = (temperature >= 20 && temperature <= 30 && isRainy);
        Console.WriteLine("문제3의 결과 : " + result15);

    }
}