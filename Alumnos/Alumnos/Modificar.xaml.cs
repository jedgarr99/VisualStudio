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
    /// Interaction logic for Modificar.xaml
    /// </summary>
    public partial class Modificar : Window
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void tbModificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String str, corr;
                str = tbFolio.Text;
                corr = tbCorreo.Text;
                Alumno a = new Alumno(int.Parse(str),corr);

                a.modificar(a);
                MessageBox.Show("Correo Modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Correo no Modificado");
            }

           
        }

        private void tbRegresar_Click(object sender, RoutedEventArgs e)
        {
            Alta w = new Alta();
            w.Show();
            this.Close();
        }
    }
}
