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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevoArticulo = new Articulo();
            ArticuloDB artDB = new ArticuloDB();

            try
            {
                nuevoArticulo.Codigo = txtCodigo.Text;
                nuevoArticulo.Nombre = txtNombre.Text;
                nuevoArticulo.Descripcion = txtDescripcion.Text;
                nuevoArticulo.Precio = decimal.Parse(txtPrecio.Text);
                nuevoArticulo.ImagenUrl = txtImagen.Text;
                nuevoArticulo.Marca = (Marcas)cbMarca.SelectedItem;
                nuevoArticulo.Categoria = (Categorias)cbCategoria.SelectedItem;

                artDB.agregar(nuevoArticulo);
                MessageBox.Show("Artículo agregado");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            MarcasDB marcaDB = new MarcasDB();
            CategoriasDB categoriaDB = new CategoriasDB();

            try
            {
                cbMarca.DataSource = marcaDB.listar();
                cbCategoria.DataSource = categoriaDB.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            { 
                pbxAgregar.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxAgregar.Load("https://www.trecebits.com/wp-content/uploads/2020/11/Error-404.jpg");
            }
        }
    }
}
