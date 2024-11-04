namespace ConsoleApp1;

class Program
{
    // 문제: 숫자 키 입력 받아 요일 출력
    //    Q.사용자로부터 1에서 7 사이의 숫자를 Console.ReadKey() 로 입력받아 해당 숫자에 맞는 요일을 출력하는 switch문을 작성하세요.
    // 1: "월요일"
    // 2: "화요일"
    // 3: "수요일"
    // 4: "목요일"
    // 5: "금요일"
    // 6: "토요일"
    // 7: "일요일"
    //그 외의 숫자가 입력되면 "잘못된 입력"을 출력하세요.
    static void Main(string[] args)
    {
        Console.WriteLine("1~7까지 숫자입력");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        Console.WriteLine();

 /*       //문자
        switch (keyInfo.KeyChar) // Char이므로 case에 숫자x
        {
            case '1': Console.WriteLine(keyInfo.KeyChar + ": 월요일"); break;
            case '2': Console.WriteLine(keyInfo.KeyChar + ": 화요일"); break;
            case '3': Console.WriteLine(keyInfo.KeyChar + ": 수요일"); break;
            case '4': Console.WriteLine(keyInfo.KeyChar + ": 목요일"); break;
            case '5': Console.WriteLine(keyInfo.KeyChar + ": 금요일"); break;
            case '6': Console.WriteLine(keyInfo.KeyChar + ": 토요일"); break;
            case '7': Console.WriteLine(keyInfo.KeyChar + ": 일요일"); break;
            default: Console.WriteLine("잘못된 입력"); break;

        }*/


        //문자 -> 숫자
        //parsing : 형태를 바꾸다. (change, conversion)
        int keyDigit = int.Parse(keyInfo.KeyChar.ToString()); // '1' -> "1" -> 1
        switch (keyDigit) 
        {
            case 1: Console.WriteLine(keyDigit + ": 월요일"); break;
            case 2: Console.WriteLine(keyDigit + ": 화요일"); break;
            case 3: Console.WriteLine(keyDigit + ": 수요일"); break;
            case 4: Console.WriteLine(keyDigit + ": 목요일"); break;
            case 5: Console.WriteLine(keyDigit + ": 금요일"); break;
            case 6: Console.WriteLine(keyDigit + ": 토요일"); break;
            case 7: Console.WriteLine(keyDigit + ": 일요일"); break;
            default: Console.WriteLine("잘못된 입력"); break;
        }


        //숫자 -> 문자
        string keyStr1 = keyDigit.ToString(); // 문자열
        Console.WriteLine("keyStr1: " + keyStr1);

        char keyChar1 = keyDigit.ToString()[0]; // 문자
        Console.WriteLine("keyChar1: " + keyChar1);


    }
}
