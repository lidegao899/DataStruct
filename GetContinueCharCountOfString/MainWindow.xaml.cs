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

namespace GetContinueCharCountOfString
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
            string input = inputbox.Text;
            resultbox.Text = GetCountOfContinueCharCount(input);
        }


        private string GetCountOfContinueCharCount(string str)
        {
            string result = "";
            char[] charArr = str.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                int tcount = 1;
                string tc = charArr[i].ToString();
                while (i + 1 < charArr.Length && charArr[i + 1] == charArr[i])
                {
                    tcount++;
                    i++;
                }
                
                result +=result.Length==0? tc + '_' + tcount:'_' +tc + '_' + tcount ;

            }



            return result;
        }
    }
}
