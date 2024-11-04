namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // 

        // 배열 array 0부터 시작 [] 안에 있는 숫자 : index(색인)
        int[] productPrices = new int[4];
        string[] productNames = new string[4];


        //연속된 메모리공간 확보
        productPrices[0] = 5000;
        productPrices[1] = 5500;
        productPrices[2] = 6000;
        productPrices[3] = 10000;

        // productPrice;  //빌드에러
        //productPrices[4] = 12000;   //런타임에러(실행 중 에러 발생. 공간 없음) 


        Console.WriteLine(productPrices[0]);

        int i = 0;
        productPrices[i] = 5200;
        Console.WriteLine(productPrices[0]);

        int book = productPrices[1] + productPrices[2];
        Console.WriteLine(book);

        Console.WriteLine();

        //배열 선언 및 초기화
        int[] products = new int[5] { 1, 2, 3, 4, 5 };
        int[] products2 = { 1, 2, 3, 4, 5 };
        Console.WriteLine(products[0]); // 1
        Console.WriteLine(products[1]); // 2
        Console.WriteLine(products2[4]); // 5
        Console.WriteLine();


        //문자열에 대한 배열(주의)
        string text = "Hello World"; // 0 1 2 3 4 5 6 7 8 9 10 총 11개의 배열을 가진다는 말
        char ch1 = text[0]; // H
        char ch2 = text[1]; // e
        char ch11 = text[10]; // d
        Console.WriteLine(ch1);
        Console.WriteLine(ch2);
        Console.WriteLine(ch11);
        Console.WriteLine();
        // char ch12 = text[11]; // 런타임에러 발생. text 11개까지만(0~10) 저장 되어있음. 



        //배열의 기본값(int 의 경우 0, float의 경우 0, double의 경우 0, string은 null)
        int[] students = new int[60];
        Console.WriteLine(students[0]); // 출력결과 0 

        float[] sosu = new float[60];
        Console.WriteLine(sosu[0]); // 출력결과 0

        double[] sosu1 = new double[60];
        Console.WriteLine(sosu1[0]); // 출력결과 0
        Console.WriteLine();
        Console.WriteLine();




        //다차원 배열
        //2차원 배열
        int[, ] arr2 = new int[60, 60]; //60*60 int 공간을 가진 2차원 배열
        int[,,] arr3 = new int[60, 60, 60]; //60*60*60 int 공간을 가진 3차원 배열
        int[,] arr4 = new int[7, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {4, 5, 6},
            {4, 5, 6},
            {4, 5, 6},
            {4, 5, 6},
        };
        Console.WriteLine(arr4[0, 1]); // 출력결과 2
        Console.WriteLine(arr4[1, 0]); // 출력결과 4
        Console.WriteLine(arr4[2, 1]); // 출력결과 5


        //가변배열(배열의 배열) 64p
        int[][] arr5 = new int[5][]; // 5개의 행을 가진 배열
        arr5[0] = new int[10];
        arr5[1] = new int[9];
        arr5[2] = new int[8];


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        //문제1 arr6의 평균값 출력(소수점까지 표시)
        int[] arr6 = {1, 2, 3, 4, 5, 6};
        int sum = arr6[0] + arr6[1] + arr6[2] + arr6[3] + arr6[4] + arr6[5];
        double avg = (double)sum/arr6.Length;
        Console.WriteLine(avg);

    }
}

        












