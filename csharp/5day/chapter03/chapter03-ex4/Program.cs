namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        // 문제1: 문자열 배열에서 길이가 4 이상인 문자열 출력
        //   Q: 아래과 같은 문자열 배열이 주어졌을 때,
        //      foreach문, if문을 사용하여 길이가 4 이상인 문자열을 출력하세요.
        string[] words = { "cat", "dog", "elephant", "lion", "tiger" };


        // (1). foreach 문을 사용하여 문자열을 출력
        foreach(string elem in words)
        {
            // (2). 길이가 4 이상인 문자열을 출력
            if(elem.Length >= 4) Console.WriteLine(elem);
        }

        // 문제2: 배열의 최대값 찾기
        //    Q: 아래와 같은 정수 배열이 주어졌을 때,
        //       foreach문, if을 사용하여 최대값을 찾아 출력하세요.
        int[] numbers = { 34, 67, 23, 89, 12, 56 };
        // 코드 작성

        int max = numbers[0]; 
        foreach(int elem1 in numbers)
        {
            if (elem1 > max)
                max = elem1;
        }
        Console.WriteLine(max);
    }
}
