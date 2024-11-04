namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        // foreach문 -> 배열일 때 많이 사용
        // 문법 
        // foreach(배열값을 받을 변수 in 표현식)
        //   구문;
        // foreach(배열값을 받을 변수 in 표현식) 구문;
        int[] arr = new int[] { 1, 2, 3, 4, 5 };
        foreach(int elem in arr)
        {
            Console.Write(elem + ", ");
        }
        Console.WriteLine();
        
        string[] arrStr = {"나는", "학교에", "간다" };
        foreach (string elem in arrStr)
        {
            Console.Write(elem + " ");
        }
        Console.WriteLine();

        foreach(string elem in arrStr)
        {
            Console.Write($"{elem}({elem.Length}개 글자)");
        }

    }
}
