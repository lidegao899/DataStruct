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

namespace _804.Unique_Morse_Code_Words
{

 

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] MorseArr = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void inputbox_KeyUp(object sender, KeyEventArgs e)
        {
            string str = inputbox.Text;
            string[] strArr = str.Split(' ');
            string newStr = "";

            foreach (string st in strArr)
            {
                newStr += st;
            }

            
            resultbox.Text = CoverToMorse(strArr);
        }

        public string CoverToMorse(string[] stArr)
        {
            List<string> MorseString = new List<string>();
            string morse = "";
            int uniqueMount = 0;
            foreach (string st in stArr)
            {
                char[] charArr = st.ToCharArray();
                string s = "";
                foreach (char c in charArr)
                {
                    s += MorseArr[c -'a'];

                }
                morse += s;
                if (!MorseString.Contains(s) && s.Length > 0)
                {
                    MorseString.Add(s);
                }
            }

            return MorseString.Count.ToString() ;
        }

    }
}
