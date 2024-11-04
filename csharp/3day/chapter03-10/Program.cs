namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {

        //Console.WriteLine(keyInfo.KeyChar);


        //제어문 - switch
        /*
        * switch(인스턴스) 인스턴스 : 변수이름
        * {
        *      case 상수식1 :
         *          구문1;
         *          break;       break 가 없으면 밑의 상수식들도 실행
         *        
         *     case 상수식2 :
         *          구문1;
         *          break;   
         *         
         *     default: // 생략 가능
         *          구문n;
         *          break;
         * }
         */

        ConsoleKeyInfo keyInfo = Console.ReadKey(); // 사용자의 1개 키보드 입력을 받은 문자를 처리
        Console.WriteLine();

        char ch = '남'; // Female
        switch(ch)
        {
            case 'M':
            case '남':
            case 'm':
                Console.WriteLine("남성");
                break;
            case 'F':
                Console.WriteLine("여성");
                break;
            default:
                Console.WriteLine("알수없음");
                break;
        }
        // if와 비교
        if (ch == 'M') Console.WriteLine("남성");  // 범위를 지정하기때문에 if를 case보다 더 사용
        else if (ch == 'F') Console.WriteLine("여성");
        else Console.WriteLine("알수없음");


        string text = "C#";
        switch (text)
        {
            case "C#":
            case "VB.NET":
                Console.WriteLine(".NET호환언어");
                break;
            case "Java":
                Console.WriteLine("JVM언어");
                break;
            default:
                Console.WriteLine("알 수 없음");
                break;
        }

        

        if (text == "C#" || text == "VB.net") Console.WriteLine(".NET호환언어");
        else if (text == "Java") Console.WriteLine("JVM언어");
        else Console.WriteLine("알수없음");


    }
}

