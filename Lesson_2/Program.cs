using System;

namespace Lesson_2
{
    class Program
    {
        //static void Swap(ref int e1, ref int e2)
        //{
        //    var temp = e1;
        //    e1 = e2;
        //    e2 = temp;
        //}
        //static int[] BubbleSort(int[,,] array)
        //{
        //    var len = array.Length;
        //    for (var i = 1; i < len; i++)
        //    {
        //        for (var j = 0; j < len - i; j++)
        //        {
        //            if (array[j] > array[j + 1])
        //            {
        //                Swap(ref array[j], ref array[j + 1]);
        //            }
        //        }
        //    }
        //    return array;
        //}

        static int GetMax(int[,,] array, int a, int b, int c)
        {
            int max = array[0, 0, 0];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        max = (array[0, 0, 0] > max ? array[0, 0, 0] : max);
                    }
                }
            }
            return max;
        }
        static int GetAlmostMax(int[,,] array, int a, int b, int c, int max)
        {
            int almostMax = array[0, 0, 0];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        if(array[0, 0, 0] > almostMax && array[0, 0, 0] < max)
                        {
                            array[0, 0, 0] = almostMax;
                        }
                    }
                }
            }
            return almostMax;
        }


        static void Main(string[] args)
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            int[,,] arr = new int[a,b,c];
            Random rnd = new Random();
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j ++)
                {
                    for(int k = 0; k < c; k++)
                    {
                        arr[i, j, k] = rnd.Next(5, 10);
                    }
                }
            }

        }
    }
}
