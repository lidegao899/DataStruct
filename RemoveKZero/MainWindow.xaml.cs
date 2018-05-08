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

namespace RemoveKZero
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;
        int inputCount = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void inputbox_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                string str = inputbox.Text;
                int.TryParse(inputbox1.Text,out inputCount);
                resultbox.Text = RemoveZero(str);
            }
            catch (InvalidCastException)
            {

            }
        }

        private string RemoveZero(string str)
        {
            if (string.IsNullOrEmpty(str)) return "NULL";

            int count = 0, index = -1;
            bool isZero = false;

            char[] charArr = str.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == '0')
                {
                    if (isZero)
                    {

                    }
                    else
                    {
                        isZero = true;
                        index = i;

                    }
                    count++;
                }
                else
                {
                    if (count == inputCount&&isZero)
                    {
                        while (index != i)
                        {
                            charArr[index++] = '*';
                        }
                    }
                    count = 0;
                    index = -1;
                    isZero = false;
                }
            }
           
            return new string( charArr);
        }
    }
}
