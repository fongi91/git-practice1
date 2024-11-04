namespace ConsoleApp1;

class Program
{
    static void Main(string[] agrs)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(); // 사용자의 1개 키보드 입력을 받은 문자를 처리
        Console.WriteLine();
        Console.WriteLine("입력한 값: " + keyInfo.KeyChar);
        
        switch (keyInfo.KeyChar)
        {
            case 'M':
            case '남':
            case 'm':
                Console.WriteLine("남성");
                break;
            case 'F':
            case 'f':
                Console.WriteLine("여성");
                break;
            default:
                Console.WriteLine("알수없음");
                break;
        }



    }
}