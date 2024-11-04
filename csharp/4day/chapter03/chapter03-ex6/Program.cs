
namespace ConsoleApp1;


class Program
{
    static void Main(string[] args)
    {
        // 문제: 로또 프로그램 만들기
        // 로또 프로그램의 조건
        //   (1) 1 ~ 45까지 랜덤한 숫자 6자리를 출력
        //   (2) 숫자 6개는 같은 숫자가 나올 수 없다.

        // 예시
        //   생성된 로또 번호: 5 6 7 19 44 1
        //   프로그램 종료

        //Random random = new Random();
        //int[] lottoNumbers = new int[6];
        //Console.Write("생성된 로또번호: ");
        //int n = 0; // n은 index
        //int m = 0;
        //while (n < 6)
        //{
        //    while (m < 6)
        //    {
        //        if (m == 0)
        //        {
        //            lottoNumbers[0] = random.Next(1, 46);
        //            m++;
        //        }
        //        else if (m != 0)
        //        {
        //            lottoNumbers[m] = random.Next(1, 46);
        //            if (lottoNumbers[m] == lottoNumbers[m - 1]) continue;
        //            else m++;
        //        }
        //    }Console.Write($"{lottoNumbers[n]} ");
        //    n++;
        //}
        //Console.WriteLine("\n프로그램 종료");



/*        Random random1 = new Random();
        int[] lottoNumbers1 = new int[6];
        Console.Write("생성된 로또번호: ");
        int a = 0;
        while (a < 6)
        {
            int b = 0;
            lottoNumbers1[a] = random1.Next(1, 46);
            while (b < 6)
            {
                lottoNumbers1[b] = random1.Next(1, 46);
                if (lottoNumbers1[a] != lottoNumbers1[b])
                    b++;
                else
                    continue;
            }
            Console.Write($"{lottoNumbers1[a]} ");
            a++;
        }
        Console.WriteLine("\n프로그램 종료");
        //중복이면 난수재설정*/




        Random random = new Random();
        int[] lottoNumbers = new int[6];
        int index = 0;

        // 코드작성(while문과 if문 break를 활용하여 작성)
        while (index < lottoNumbers.Length)
        {
            int newNumber = random.Next(1, 46);
            bool isDuplicate = false;
            
            //중복된 값이 있는지 체크하는 코드
            int checkIndex = 0;
            while(checkIndex < index)
            {
                if (lottoNumbers[checkIndex] == newNumber)
                {
                    isDuplicate = true;
                    break;

                }
                else checkIndex++;
            }

            if (!isDuplicate)    // 중복된 값이 없으면 로또번호로 저장
            {
                lottoNumbers[index] = newNumber;
                index++;
            }
        }
        Console.WriteLine("생성된 로또 번호:");
        int printIndex = 0;
        while (printIndex < lottoNumbers.Length)
        {
            Console.Write(lottoNumbers[printIndex] + " ");
            printIndex++;
        }

        }
      
    }
}
