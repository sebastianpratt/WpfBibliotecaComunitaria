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

namespace WpfBibliotecaComunitaria
{
    /// <summary>
    /// Lógica de interacción para Autores.xaml
    /// </summary>
    public partial class Autores : Window
    {
        public Autores()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void lstDispositivos_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void lstDispositivos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstDispositivos.SelectedItem != null)
            {
                Autor d = (Autor)lstDispositivos.SelectedItem;
                txtId.Text = d.NroDocmeno.ToString();
                txtTipo.Text = d.TipoDcumento.ToString();
                txtN.Text = d.NombreFantasia;
                txtNo.Text = d.Nombres;
                txta.Text = d.Apellidos;
                txtD.Text = d.Direccion;
                txtT.Text = d.Telefono;
                txtM.Text = d.Mail;
                txtc.Text = d.Ciudad.ToString();
            }
        }
    }
}
