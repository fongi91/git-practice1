﻿using System;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        string text1 = "안녕하세요";
        Console.WriteLine(text1);

        // for 문으로 분할해서 출력(String 배열을 이동)
        for (int i = 0; i < text1.Length; i++)
        {
            Console.WriteLine(text1[i]);
        }



        // 문제: 문자열 뒤집기
        //   Q: 사용자로부터 문자열을 입력받아 그 문자열을 뒤집어서 출력하세요.
        //       단일 for문을 사용하세요.
        // 예시: 문자열을 입력하세요: 안녕하세요
        //       뒤집힌 문자열: 요세하녕안
        //       문자열을 입력하세요: 교실
        //       뒤집힌 문자열: 실교
        //       문자열을 입력하세요: 수원
        //       뒤집힌 문자열: 원수

        // 힌트: 감소연산자(--) -> ex) for (int i = 9; i >= 0; i--)

        while(true)
        { 
            Console.WriteLine("문자열을 입력하시오");
            string input = Console.ReadLine();
            string reverse = "";
       
        
            for (int i = (input.Length - 1); i >= 0; i--)
        {
                reverse = reverse + input[i];
        }
            Console.WriteLine(reverse);
        }
    }
}