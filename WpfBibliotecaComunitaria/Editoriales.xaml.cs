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
    /// Lógica de interacción para Editoriales.xaml
    /// </summary>
    public partial class Editoriales : Window
    {
        public Editoriales()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }

        private void lstMarca_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstMarca.SelectedItem != null)
            {
                ClaseEditorial MarcaSeleccionada = (ClaseEditorial)lstMarca.SelectedItem;
                txtId.Text = MarcaSeleccionada.EditorialID.ToString();
                txtINombre.Text = MarcaSeleccionada.NombreEditorial;
                txtDi.Text = MarcaSeleccionada.Direccion;
                txtTelefono.Text = MarcaSeleccionada.Telefono;
                txtCiudad.Text = MarcaSeleccionada.CiudadID.ToString();

            }
        }

        private void lstMarca_Loaded(object sender, RoutedEventArgs e)
        {
            ObtenerDatos();
        }

        private async void ObtenerDatos()
        {
            List<ClaseEditorial> lista = await ClaseEditorial.ObtenerEditorial();
            lstMarca.ItemsSource = lista;
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ClaseEditorial m = new ClaseEditorial();
            //m.ID_Marca = Convert.ToInt32(txtIdMarca.Text);
            m.NombreEditorial = txtINombre.Text;


            await ClaseEditorial.NuevaEditorial(m);
            ObtenerDatos();
            limpiar();
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (lstMarca.SelectedItem != null)
            {
                ClaseEditorial MarcaSeleccionada = (ClaseEditorial)lstMarca.SelectedItem;
                MarcaSeleccionada.EditorialID = Convert.ToInt32(txtId.Text);
                MarcaSeleccionada.NombreEditorial = txtINombre.Text;
                MarcaSeleccionada.Direccion = txtDi.Text;
                MarcaSeleccionada.Telefono = txtTelefono.Text;
                MarcaSeleccionada.CiudadID = Convert.ToInt32(txtCiudad.Text);


                await ClaseEditorial.ActualizarEditorial(MarcaSeleccionada);
                ObtenerDatos();
                limpiar();
            }
            else
                MessageBox.Show("Debe seleccionar primeramente la Marca a modificar ");
        }

        private void limpiar()
        {
            txtId.Text = string.Empty;
            txtINombre.Text = string.Empty;
            txtDi.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCiudad.Text = string.Empty;
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (lstMarca.SelectedItem != null)
            {
                ClaseEditorial MarcaSeleccionada = (ClaseEditorial)lstMarca.SelectedItem;
                await ClaseEditorial.ActualizarEditorial(MarcaSeleccionada);
                ObtenerDatos();
                limpiar();
            }
            else
                MessageBox.Show("Debe seleccionar primeramente la Marca a eliminar ");
        }
    }
}
