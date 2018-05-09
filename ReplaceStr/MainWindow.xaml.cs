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

namespace ReplaceStr
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
            string str = inputbox.Text;
            string from = frombox.Text;
            string to = tobox.Text;
            resultbox.Text = ReplaceStr(from, to, str);
        }
        private string ReplaceStr(string from, string to, string str)
        {
            var strArr = str.ToCharArray();
            var fromArr = from.ToCharArray();
            int match = 0;
            for (int i = 0; i < strArr.Length; i++)
            {

                if (strArr[i] == fromArr[match++])
                {
                    if (match == fromArr.Length)
                    {
                        Clear(ref strArr, i, fromArr.Length);
                        match = 0;
                    }
                }
                else
                {
                    if (strArr[i] == fromArr[0])
                        i--;
                    match = 0;
                }
            }
            string resultStr = "";
            string cur = "";
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i] != 0)
                {
                    resultStr += strArr[i];
                }
                if (strArr[i] == 0 && (i == 0 || strArr[i - 1] != 0))
                {
                    resultStr += cur + to;
                    cur = "";
                }
            }
            if (cur.Length != 0)
                resultStr += cur;
            //Clear(ref strArr, 0, 2);
            //string resultStr = "";
            return resultStr;
        }

        private void Clear(ref char[] chararr, int end, int len)
        {
            //for (int i = end; i == end - len; i--)
            //{
            //    chararr[i] = 0;
            //}

            while (len-- > 0)
            {
                chararr[end--] = (char)0;
            }
        }


    }
}
