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

namespace Alumnos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txUsuario.Text = "jorge";
            txPassword.Text = "hola";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String res = Conexion.comprobarPwd(txUsuario.Text, txPassword.Text);
            if (res.Equals("contraseña correcta"))
            {
                //MessageBox.Show("Mandar a la siguiente pantalla");
                Alta w = new Alta();
                w.Show();
                this.Close();
            }
            else
                MessageBox.Show(res);
        }

        private void TxUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
