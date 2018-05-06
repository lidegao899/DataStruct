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

namespace StrSumNum
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
            string inputText = inputbox.Text;
            resultbox.Text = countSum( inputText);
        }

        private string countSum(string str)
        {
            if (string.IsNullOrEmpty(str))
                return "0";
            char[] charArr = str.ToArray();
            int res = 0, num = 0,cur=0;
            bool posi = true;
            for (int i = 0; i < charArr.Length; i++)
            {
                if (char.IsNumber(charArr[i]))
                {
                    cur = int.Parse(charArr[i].ToString());
                    num = num * 10 + (cur = posi ? cur : -cur);
                }
                else
                {
                    if (charArr[i] - '-' == 0)
                    {
                        if (i == 0)
                        {
                            posi = false;
                        }
                        else
                        {
                            if (charArr[i - 1] - '-' == 0)
                                posi = !posi;
                            else
                                posi = false;
                        }
                    }
                    else
                    {
                        posi = true;
                    }
                    res +=num;
                    num = 0;


                }
            }

            res +=num;
            num = 0;

            return res.ToString();

        }
    }
}
