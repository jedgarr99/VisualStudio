﻿using System;
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

namespace RegistroAspirantes
{
    /// <summary>
    /// Interaction logic for Modificacion.xaml
    /// </summary>
    public partial class Modificacion : Window
    {
        public Modificacion()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bRegresar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Conexion.llenarCombo(cbProgramas);
            Conexion.llenarCombo2(cbAspirantes);
        }
    }
}
