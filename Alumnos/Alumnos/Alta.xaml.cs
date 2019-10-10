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
    /// Interaction logic for Alta.xaml
    /// </summary>
    public partial class Alta : Window
    {
        public Alta()
        {
            InitializeComponent();
            txClaveUnica.Text = "15";
            txNombre.Text = "edgar";
            txSexo.Text = "hombre";
            txCorreo.Text = "dfbgnhjmk";
            txSemestre.Text = "4";
            

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Conexion c = new Conexion();
            c.llenarComboAlta(cbProgramas);
        }

        private void BtAgregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
         
                Alumno a = new Alumno(Int32.Parse(txClaveUnica.Text), txNombre.Text, txSexo.Text, txCorreo.Text, short.Parse(txSemestre.Text), 2);
                a.agregar(a);
                MessageBox.Show("Alumno Dado de Alta");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Alumno  no Dado de Alta");
            }
        }

        private void BtEliminar_Click(object sender, RoutedEventArgs e)
        {
            
                Baja w = new Baja();
                w.Show();
                this.Close();
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Buscar w = new Buscar();
            w.Show();
            this.Close();
        }

        private void BtModificar_Click(object sender, RoutedEventArgs e)
        {
            Modificar w = new Modificar();
            w.Show();
            this.Close();
        }

        private void BtSalir_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }

        private void TxClaveUnica_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
