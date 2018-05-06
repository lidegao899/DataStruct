using System;

namespace DataStruct
{
	class MainClass
	{
        
        
        public static void Main (string[] args)
		{
            int lenOfArr =10;
             int[] myarray = new int[lenOfArr];
            
            Random ran = new Random();

            for(int i= 0;i < myarray.Length;i++)
                myarray[i]= ran.Next(10000);


            

            //Boble_Sort(myarray);

            //Partition_Sort(myarray, 0, myarray.Length-1);

            //Insert_Sort(myarray);

            printArr(myarray);
            Half_Insert_Sort(myarray);

            printArr(myarray);
            //Console.ReadKey();

        }


        static void Shell_Sort(int[] arr) {



        }

        static void Half_Insert_Sort(int[] arr) {

            int low = 0, high = arr.Length, mid = 0;

            //Console.WriteLine(mid);
            if (arr[0] > arr[1]) {
                int temp = arr[0];
                arr[0] = arr[1];
                arr[1] = temp;
            }
            printArr(arr);

            for (int i = 2; i < arr.Length; i++)
            {

                int temp = arr[i];
                low = 0;
                high = i;

                while (low <=high)
                {

                    mid = (low + high) / 2;

                    if (arr[mid] < temp)
                    {
                        low = mid+1;
                    }
                    else if (arr[mid] >= temp)
                    {
                        high = mid-1;
                    }
                    else break;
                    
                }
                Console.WriteLine(high + 1);
                for (int j = i; j>high+1; j--) {
                    arr[j] = arr[j - 1];
                }
                arr[high+1] = temp;

            }

           

        }


        static void Insert_Sort(int[] arr) {

            for (int i = 1; i < arr.Length; i++) {
                //Console.WriteLine(i);
                int temp = arr[i];
                int j = i;
                for (; j > 0 && arr[j - 1] > temp; j--) arr[j ] = arr[j-1];

                arr[j] = temp;

                //printArr(arr);
            }

        }



        static void Partition_Sort(int[] arr,int low,int high) {
            if (low >= high) return;

            int pirot = Partition(arr, low, high);

            Partition_Sort(arr, low, pirot-1);
            Partition_Sort(arr, pirot+1 , high);

            //printArr(arr);
        }
        static int Partition(int[] arr, int low, int high) {

            int priot = arr[low];

            while (low < high) {

                while (low < high && arr[high] >= priot) high--;
                arr[low] = arr[high];
                while (low < high && arr[low] <= priot) low++;
                arr[high] = arr[low];
            }

            arr[low] = priot;

            //printArr(arr);
            //Console.WriteLine(low);
            return low;

        }



        static void Boble_Sort(int[] arr) {
            int temp;
            for (int i=0; i < arr.Length; i++)
            {
                bool flag = false;
                //temp = arr[0];
                for (int j = arr.Length-1; j > i; j--)
                {
                    if (arr[j-1] > arr[j]) {
                        temp = arr[j];
                        arr[j] = arr[j-1];
                        arr[j-1] = temp;
                        flag = true;
                    }

                }
                if (flag == false) break;

            }

            Console.Write("Boble_Sort");
            printArr(arr);
            //Console.ReadKey();
        }


        static void printArr(int[] arr) {

            foreach (int n in arr)
                Console.Write(n + " ");
            Console.WriteLine();


        }
	}
}
