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
    public partial class frmVerDetalle : Form
    {
        public frmVerDetalle()
        {
            InitializeComponent();
        }
        public frmVerDetalle(Articulo articulo)
        {
            InitializeComponent();
            frmVerDetalle_Load(articulo);
            
        }
        public void frmVerDetalle_Load(Articulo articulo)
        {
            ArticuloDB articuloDB = new ArticuloDB();

            try
            {
                txtCodigo.Text = "Codigo: " + articulo.Codigo;
                txtNombre.Text = "Nombre: " + articulo.Nombre;
                txtDescripcion.Text = "Descripcion: " + articulo.Descripcion;
                txtMarca.Text = "Marca: " + articulo.Marca.Descripcion;
                txtCategoria.Text = "Categoria: " + articulo.Categoria.Descripcion;
                txtPrecio.Text = "Precio: $ " + articulo.Precio;
                txtImagenUrl.Text = "URL: " + articulo.ImagenUrl;
                
                cargarImagenDetalle(articulo.ImagenUrl);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void cargarImagenDetalle(string imagen)
        {
            try
            {
                pxbDetalle.Load(imagen);
            }
            catch (Exception ex)
            {
                pxbDetalle.Load("https://www.trecebits.com/wp-content/uploads/2020/11/Error-404.jpg");
            }
        }

        private void frmVerDetalle_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoria_Click(object sender, EventArgs e)
        {

        }

        private void txtImagenUrl_Click(object sender, EventArgs e)
        {

        }
    }
}
