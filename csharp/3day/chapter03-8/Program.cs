namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        /* 제어문
         * (1) if(조건문(관계연산자 or 논리연산자) 
         *       구문; (조건문이 true이면 '구문' 실행. false 이면 실행 x)
         *       구문의 단위는 ';' 로 구분
         *       
         *     if(조건문) 구문;
         *     if문에 중괄호가 없는 경우 구문을 1개만 실행.
         *     if문에 중괄호가 있는 경우 구문을 1개이상 실행.
         *       
         */
        // 3의배수일 경우 '3의배수' 출력이 되는 프로그램 생성
        // (으로 나누었을 때 0)
        int a = 5;
        int b = 8;
        if (a % 3 == 0) // false
            Console.WriteLine("a는 3의배수이다.");
        if ((b % 3 == 0) && (b % 2 == 0)) // true
        {
            Console.WriteLine("b는 2의배수");
            Console.WriteLine("b는 3의배수"); // 중괄호가 없으면 무조건 실행이 된다.
        }

        if (6 % 4 == 0)
        { 
            Console.WriteLine("6은 3의배수이다.");
            Console.WriteLine("연산결과 끝~");
        }
        Console.WriteLine("연산결과 끝~~~~~~~~~\n\n\n\n\n");


        // value변수의 값과 if문으로 짝수 홀수 구분해서 출력하기.
        long value = 100000000000;
        if (value % 2 == 0) // true 일 경우 실행
        {
            Console.WriteLine("value는 2의 배수");
            Console.WriteLine("따라서 value는 짝수이다.");
        }
        else Console.WriteLine("value는 홀수"); // false 일 경우 실행 


        // else if 사용하기. if문을 계속 넣는개념
        if (value <= 255) Console.WriteLine("byte로 변환이 가능");
        else if (value <= 65535) Console.WriteLine("ushort 변환 가능");
        else if (value <= 2100000000) Console.WriteLine("int형으로 변환 가능");
        else Console.WriteLine("long 타입");


        // 삼항 연산자 ***
        // 문법: (조건식) ? 표현식1 : 표현식
        // 설명: 조건식이 true 이면 표현식1 을 실행, false 이면 표현식2를 실행
        // 

        int value2 = 5;
        string result;
        if (value2 % 2 == 0)
        {
            result = "짝수";
        }
        else
        {
            result = "홀수";
        }
        Console.WriteLine(result);

        //위의 코드를 삼항연산자로 표현이 가능
        string result2 = (value2 % 2 == 0) ? "짝수" : "홀수";
        Console.WriteLine(result2+"\n\n\n\n\n");




        // 문제1. age>=20, hasLicense가 true 인 경우 "운전가능", 아니면 "운전불가"
        int age = 30;
        bool hasLicense = true;
        string result3 = (age >= 20 && hasLicense) ? "운전가능" : "운전불가";
        Console.WriteLine(result3); // 삼항연산자에 직접 Console.WritLine -> 오류 

       

        // 문제2. isWeekend와 isHoliday 중 하나라도 true 인 경우
        // '쉬는날입니다' 출력 / false인 경우 '일하는날입니다' 출력
        bool isWeekend = false;
        bool isHoliday = true;
        string result4 = (isWeekend || isHoliday) ? "쉬는날입니다." : "일하는날입니다.";
        Console.WriteLine(result4);










    }
}