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
using System.Windows.Shapes;

namespace Alumnos
{
    /// <summary>
    /// Interaction logic for Buscar.xaml
    /// </summary>
    public partial class Buscar : Window
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Alumno a = new Alumno();
            List<Alumno> res = a.buscar(txNombre.Text);

            dgDos.ItemsSource = res;


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Alta w = new Alta();
            w.Show();
            this.Close();
        }
    }
}
