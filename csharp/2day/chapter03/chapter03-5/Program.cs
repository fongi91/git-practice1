namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // 예약어(preserved) = 키워드 : C# 에서 미리 사용하고 있는 단어
        
        
        // 식별자 : 프로그래밍 하면서 임의로 선택해서 이름 지을 수 있는 단어
        // 대소문자를 구별함
        int Main = 1;
        int main = 2;

        string \u00620 = "가능";
        Console.WriteLine(\u00620);


        //null 키워드 사용하기
        string? text = null;
        string? text1 = null;   // ?의 의미 : null 사용을 허용하겠다.(null은 값이 었는 것)
        string text2 = " "; // empty. null과 다름. 1bit라는 값을 차지함.

        text = "null"; // null이 아님. "null: 이라는 문자
        int? a1 = 1; // ?을 넣어 메모리상에 '지우는 것' 이 가능
        a1 = null;

        Console.WriteLine("a1 : " + a1);
        Console.WriteLine("text : " + text);

        System.Int32? a2 = 1;
        a2 = null;

        Console.WriteLine();
        Console.WriteLine();



        // 데이터 타입의 기본값
        string result; // 기본값 : false. 권장하지 않는 형식(값까지 설정해야..)
        int a; // 기본값 : 0 권장하지 않는 형식(값까지 설정해야..)
        




        // 상수(변하지 않는 수 - const키워드) : const 가 붙은 변수명은 값 수정 시 에러 발생
        //   ex) 원의 넓이를 구할 때 PI = 3.141592...
        const bool result2 = false;
        // result2 = true;


        const double PI = 3.14;
        // PI = 3.25; -> 오류발생(const로 선언해서)

        const string Jumin = "910315-1234567";
        // Jumin = "913332-1234567"; -> 오류발생(const로 선언해서)

        const int n1 = 10 + 10;
        // 이런 방식은 가능.

        int n = Math.Max(n1, 5);



        // 연산자(+, -, *, /, %)
        // % : 나누었을 때의 나머지
        int z1 = 3 % 2;
        Console.WriteLine("3 % 2의 나머지는 " + z1);

        int z2 = 4 % 2;
        Console.WriteLine("4 % 2의 나머지는 " + z2);

        int x1 = 3 / 2;
        Console.WriteLine("3/2 의 값은 " + x1); // 1
        double x2 = 3.0 / 2; //      정수/정수 = 정수,     실수/정수 = 실수
        Console.WriteLine("3/2 의 값은 " + x2); // 1.5

        double x3 = 3 / (double)2;
        Console.WriteLine("3/2 의 값은 " + x3); // 1.5







    }
}

