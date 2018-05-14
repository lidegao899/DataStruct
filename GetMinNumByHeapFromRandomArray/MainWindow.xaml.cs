using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GetMinNumByHeapFromRandomArray
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        int arrSize = 10000;
        int heapSize = 50;

        int[] heap;

        public MainWindow()
        {
            InitializeComponent();
            heap = new int[heapSize];
            var rawArr = ArrIntCreator();
            string rawst = IntArrToStr(rawArr);
            inputbox.Text = rawst;
            for (int i = 0; i < heapSize; i++)
            {
                heapInsert(ref heap, rawArr[i], i);
            }
            inputbox1.Text = IntArrToStr(heap);

            for (int i = heapSize-1; i < rawArr.Length; i++)
            {
                if (rawArr[i] < heap[0])
                {
                    heapify(ref heap, 0, rawArr[i]);
                }

            }
            resultbox.Text = IntArrToStr(heap);


        }


        public void heapInsert(ref int[] arr,int value,int index)
        {
            arr[index] = value;
            int parent = (index - 1) / 2;
            while (index != 0)
            {
                if (arr[index] > arr[parent])
                {
                    Swap(ref arr, index, parent);
                    index = parent;
                    parent = (index - 1) / 2;
                }
                else
                    break;
            }
        }


        public void heapify(ref  int[] arr, int index, int value)
        {
            arr[index] = value;
            int Large = index;
            int Left = index * 2 + 1;
            int Right = index * 2 + 2;
            while (Left < arr.Length)
            {
                if (arr[index] < arr[Left]) Large = Left;
                if (Right < arr.Length && arr[Right] > arr[Large]) Large = Right;

                if (arr[Large] > arr[index])
                {
                    Swap(ref arr, Large, index);
                    index = Large;
                    Left = index * 2 + 1;
                    Right = index * 2 + 2;
                }
                else
                {
                    break;
                }

            }

        }

        public void Swap(ref int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
        public string IntArrToStr(int[] intArr)
        {
            string str = "";
             foreach (int i in intArr)
            {
                str += i + " ";
            }
            return str;
        }



        public int[] ArrIntCreator()
        {
            int[] arr = new int[arrSize];

            Random ran = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]= ran.Next(100000);
            }

            return arr;
        }

        private void inputbox_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }

    


}
