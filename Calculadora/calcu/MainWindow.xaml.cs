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

namespace calcu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(tb1.Text=="0")
                tb3.Text = "ERROR";
            else
                tb3.Text = "1";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int aa;
            string a;

            a = tb1.Text;
            aa = Convert.ToInt32(a);
            tb3.Text = ""+Math.Abs(aa);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double aa;
            string a;

            a = tb1.Text;
            aa = Convert.ToDouble(a);
            tb3.Text = "" + Math.Ceiling(aa);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            tb3.Text = "JORGE";
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            double aa;
            string a;

            a = tb1.Text;
            aa = Convert.ToDouble(a);
            tb3.Text = "" + Math.Floor(aa);
        }
    }
}
