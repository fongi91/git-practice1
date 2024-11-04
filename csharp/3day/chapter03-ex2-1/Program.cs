namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("메뉴");
        Console.WriteLine("1. 프로그램 시작");
        Console.WriteLine("2. 설정 변경");
        Console.WriteLine("3. 프로그램 종료");

        ConsoleKeyInfo keyInfo = Console.ReadKey();
        int keyDigit = int.Parse(keyInfo.KeyChar.ToString());

        Console.WriteLine();
        string keyStr1 = keyDigit.ToString();
        char keyChar1 = keyDigit.ToString()[0];
        char keyChar2 = keyDigit.ToString()[1];

        switch (keyDigit)
        {
            case 1: Console.WriteLine("입력 : " + keyDigit); break;
            case 2: Console.WriteLine("입력 : " + keyDigit); break;
            case 3: Console.WriteLine("입력 : " + keyDigit); break;
            default: Console.WriteLine("없음"); break;

        }

    }

}