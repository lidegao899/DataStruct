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

namespace IsDeformation
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

        private void st1_KeyDown(object sender, KeyEventArgs e)
        {
            tb.Text = IsDefomation(st1.Text, st2.Text).ToString() ;
        }

        private void st2_KeyDown(object sender, KeyEventArgs e)
        {
            tb.Text = IsDefomation(st1.Text, st2.Text).ToString();
        }

        private bool IsDefomation(string st1, string st2)
        {
            if (st1.Length == 0 || st2.Length == 0 || st1.Length != st2.Length)
                return false;
            int[] m = new int[256];
            char[] c1 = st1.ToCharArray();
            char[] c2 = st2.ToCharArray();
            //数组初始值为0？
            for (int i = 0; i < c1.Length; i++)
                m[c1[i]]++;
            for (int i = 0; i < c2.Length; i++)
                if (m[c2[i]]-- == -1) return false;
            return true;



            return false;
        }
    }
}
