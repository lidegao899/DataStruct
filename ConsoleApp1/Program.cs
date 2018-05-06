using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = CreateArr(100);
            int count = 0;
            foreach (var i in arr)
            {
                Console.Write(count+++":"+i + " ;");
            }
            Console.WriteLine();
            Console.WriteLine(halfSearch(arr, 66));
            System.Console.ReadKey();
        }


        /// <summary>
        /// 创建顺序数组
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int[] CreateArr(int n)
        {
            //if (n <= 0)
            //{
            //    return null;
            //}
            Random ran = new Random();
            int[] arr = new int[n];
            arr[0] = 2;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + ran.Next(1, 1);
            }
            return arr;
        }

        static int halfSearch(int[] arr, int num)
        {
            int min = 0, max = arr.Length - 1, mid = max / 2;
            while (min < max)
            {
                if (num < arr[mid])
                {
                    max = mid - 1;

                }
                else if (num > arr[mid])
                {
                    min = mid + 1;
                }
                else
                    return mid;

                mid = (max + min) / 2;
            }
            if (max == min)
                return min;
            else
                return -1;
        }
    }
}
