﻿using System.Diagnostics;

namespace ex08_generics
{
    internal class Program
    {
        // 배열 복사 기능 -> 일반화 프로그래밍
        // 매서드 뒤에 <T>, 각 매개변수의 타입 대신 T로 변경
        static void CopyArray<T>(T[] src, T[] dest)
        {
            for (int i = 0; i < src.Length; i++)
                dest[i] = src[i];
        }
        //static void CopyArray(float[] src, float[] dest)
        //{
        //    for (int i = 0; i < src.Length; i++)
        //        dest[i] = src[i];
        //}
        //static void Main(string[] args)
        //{
        //    int[] array1 = {10, 20, 30, 50, 70};
        //    int[] array2 = new int[5];

        //    CopyArray(array1, array2);


        //    Console.WriteLine(array2);

        //    float[] array3 = { 3.4f, 2.2f, 7.7f };
        //    float[] array4 = new float[array3.Length];

        //    CopyArray(array3, array4);
        //    Console.WriteLine(array4[0]);
        //}
    }
}
