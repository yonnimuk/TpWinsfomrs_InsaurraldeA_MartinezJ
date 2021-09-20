using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using DBArticulo;

namespace Catalogo
{
    public partial class frmBuscar : Form
    {
        private List<Articulo> articuloLista;
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargar()
        {
            ArticuloDB articulo = new ArticuloDB();
            try
            {
                articuloLista = articulo.buscar(cbxBuscar.Text, txtBuscado.Text);
                dgvBuscar.DataSource = articuloLista;
                dgvBuscar.Columns["Id"].Visible = false;
                dgvBuscar.Columns["ImagenUrl"].Visible = false;
                cargarImagen(articuloLista[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxBuscar.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxBuscar.Load("https://www.trecebits.com/wp-content/uploads/2020/11/Error-404.jpg");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvBuscar_SelectionChanged(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado = (Articulo)dgvBuscar.CurrentRow.DataBoundItem;
            cargarImagen(articuloSeleccionado.ImagenUrl);
        }
    }
}
