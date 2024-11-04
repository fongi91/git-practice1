using System.Diagnostics;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // 문제 4: 모음 / 자음 판별
        // Q.사용자로부터 알파벳 문자를 입력받아 해당 문자가 모음(a, e, i, o, u)인지 자음인지
        // 판별하는 프로그램을 작성하세요.대소문자 구분 없이 처리하고 Console.ReadKey()를 사용하세요.

        Console.Write("알파벳 문자를 입력하세요: ");
        ConsoleKeyInfo charKey = Console.ReadKey();
        Console.WriteLine();  // 줄바꿈
        char result = charKey.KeyChar;


        if (result == 'a' || result == 'e' || result == 'i' || result == 'o' || result == 'u')
            Console.WriteLine("모음입니다.");
        else if (result == 'A' || result == 'E' || result == 'I' || result == 'O' || result == 'U')
            Console.WriteLine("모음입니다.");
        else if (((int)result >= 65 && (int)result <= 90) || ((int)result >= 97 && (int)result <= 122))
            Console.WriteLine("자음입니다");
        else Console.WriteLine("잘못된 값입니다.");




        char letter = charKey.KeyChar;
        switch (letter)
        {
            case 'a': case 'A':
            case 'e': case 'E':
            case 'i': case 'I':
            case 'o': case 'O':
            case 'u': case 'U':
                Console.WriteLine("모음입니다");
                break;
            default:
                if ((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z'))
                    Console.WriteLine("자음입니다.");
                else
                    Console.WriteLine("잘못된 입력입니다. 알파벳 문자를 입력하세요");
                break;

                // if (char.IsLetter(letter)) ; // isLetter는 문자인지 찾아주는 함수

        }

    }
}

