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

namespace _461.Hamming_Distance
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void inputbox_KeyUp(object sender, KeyEventArgs e)
        {
            string input1 = inputbox.Text;
            string input2 = inputbox1.Text;
            if (input1.Length < 1 || input2.Length < 1) return;
            int[] int1 = CoverToBinaryInt(int.Parse(input1));
            int[] int2 = CoverToBinaryInt(int.Parse(input2));
            int Distance = 0;
            for (int i = 0; i < int1.Length; i++)
            {
                if (int1[i] != int2[i]) Distance++;           
            }
            resultbox.Text = Distance.ToString();
        }

        public int[] CoverToBinaryInt(int number)
        {
            int[] bint = new int[32];
            for (int i = 0; number > 0; i++)
            {
                bint[i] = number % 2;
                number = number / 2;
            }
            return bint;
        }
    }
}
