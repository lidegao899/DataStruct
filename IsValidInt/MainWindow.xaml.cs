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

namespace IsValidInt
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
            char[] charArr = inputbox.Text.ToCharArray();
            inputbox1.Text = IsValidInt(charArr).ToString();
            if (IsValidInt(charArr))
            {
                resultbox.Text = ConverStrToInt32(charArr).ToString();
            }
            else
            {
                resultbox.Text = "InValid";
            }
        }

        private bool IsValidInt(char[] charArr)
        {
            if (charArr.Length == 0) return false;
            if (charArr[0] == '0')
            {
                return charArr.Length == 1;
            }
            if (charArr.Length == 1)
            {
                return char.IsNumber(charArr[0]);
            }
            if (charArr[0] == '-')
            {
                if (charArr[1] == '0' || !char.IsNumber(charArr[1])) return false;
            }
            else if (!char.IsNumber(charArr[0])) return false;

            

            for (int i = 1; i < charArr.Length; i++)
            {
                if (!char.IsNumber(charArr[i])) return false;
            }
            return true;
        }

        private int  ConverStrToInt32(char[] charArr)
        {
            //通过乘10法计算，边界条件是最后一个乘10，以及最大值的余数，必须判断是否越界
            int minq = Int32.MinValue / 10;
            int minr = Int32.MinValue % 10;
            int res = 0, cur = 0;
            for (int i = charArr[0] == '-' ? 1 : 0; i < charArr.Length; i++)
            {
                cur ='0'-charArr[i];
                if (res < minq || (res == minq && cur < minr)) return 0;
                res = res * 10 + cur;
            }

            //上越界
            if (charArr[0] != '-' && res == Int32.MinValue) return 0;

            return charArr[0]=='-'?res:-res;
        }
    }
}
