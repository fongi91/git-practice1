
class Program
{
    static void Main(string[] args)
    {
        // 문제: 3의 배수 합 구하기(기회 제한)
        //    Q: 사용자로부터 0 이상의 숫자를 입력받아 3의 배수의 합을 계산하는 프로그램을 작성하세요.
        //       조건은 다음과 같습니다.
        //       (1) 사용자는 최대 10번의 입력 기회를 갖습니다 (while 사용).
        //       (2) 3의 배수가 아닌 경우 "3의 배수만 합산됩니다."를 출력하고 다음 입력을 받습니다 (continue 사용)
        //       (3) 사용자가 -1을 입력하면 반복을 종료합니다 (break 사용).
        //       (4) 10번의 입력 기회가 끝나면 최종 합을 출력하고 한 줄 띄워서 '프로그램 종료'라는 것도 출력

        int count = 0; // 입력기회 변수
        int sum = 0; // 합 변수
        Console.WriteLine("[3의배수 합 구하기]");
        while (count < 10) // 1. 10번의 입력기회 부여
        {
            count++;
            Console.Write("숫자 입력(-1 입력 시 종료): ");
            int n = int.Parse(Console.ReadLine()); 
            
            // string input = Console.ReadLine();
            // int number = int.Parse(input);

            // 3. -1을 입력하면 반복 종료코드
            if (n == -1)
            {
                Console.WriteLine("반복을 종료합니다.");
                break;
            }

            // 2. 3의배수가 아닌경우 "3의 배수만 합산됩니다" 출력 및 다음 입력 코드
            if ((n % 3 != 0) && (n <=0))
            {
                Console.WriteLine("3의 배수만 합산됩니다.");
                continue;
            }
            sum = sum + n; 
        }

        // 4. 10번의 입력기회가 끝나면 최종 합을 출력 + '프로그램 종료' 출력
        Console.WriteLine($"최종 합 : {sum}\n프로그램 종료");
    }
}
