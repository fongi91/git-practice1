using System.Security.Cryptography;

namespace ConsoleApp1;


class Program
{
    static void Main(string[] args)
    {
        /*        Random random = new Random();
                int rndNumber = random.Next(1, 100); // 1~99 중 랜덤으로 한 숫자 저장
                Console.WriteLine(rndNumber);


                int rndNumber1 = random.Next(3, 9); // 3~8 중 랜덤으로 한 숫자 저장
                Console.WriteLine(rndNumber1);*/

        // 문제: (1) 랜덤한 값을 1 ~ 20까지 지정을 합니다.
        //       (2) 랜덤한 값이 3 ~ 7 사이인 경우 '3 ~ 7 사이 입니다'라고 출력
        //       (3) 만약 숫자가 5이면 '프로그램을 종료합니다' 출력

        // 예시
        // 랜덤 숫자 88
        // 랜덤 숫자 50
        // 랜덤 숫자 6, 3 ~ 7 사이 입니다.
        // 랜덤 숫자 8
        // 랜덤 숫자 9
        // 랜덤 숫자 5
        // 프로그램을 종료합니다.

        int cnt = 0;
        const int fixNumber = 5;
        // 무한루프. break가 될 때까지 계속 돌린다.
        while (true)
        {
            // 돌린 횟수 : count
            cnt++;
            Random random = new Random();
            int rndNumber = random.Next(1, 21); // 1~20까지 
            if (rndNumber >= 3 && rndNumber <= 7)
            {
                // rndNumber 5 나오면 프로그램 종료
                if (rndNumber == fixNumber)
                {
                    Console.WriteLine($"랜덤 숫자 {rndNumber}, \n랜덤을 {cnt}번 돌렸을 때 {fixNumber}가 나왔습니다.");
                    break;
                }
                else
                Console.WriteLine($"랜덤 숫자 {rndNumber}, 3 ~ 7 사이입니다.");                
            }
            // 3~7사이가 아닌 숫자
            else
                Console.WriteLine($"랜덤 숫자 {rndNumber}");
        }
        Console.WriteLine("프로그램을 종료합니다.");
    }






}

