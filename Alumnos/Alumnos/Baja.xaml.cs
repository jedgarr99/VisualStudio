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
    /// Interaction logic for Baja.xaml
    /// </summary>
    public partial class Baja : Window
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void btBaja_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String str;
                str = tbFolio.Text;
                Alumno a = new Alumno();
                a.eliminar(int.Parse(str));
                MessageBox.Show("Alumno Dado de Baja");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alumno  no Dado de Baja");
            }
        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            Alta w = new Alta();
            w.Show();
            this.Close();
        }
    }
}
