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
        private Articulo articulo = null;
        public frmAgregar()
        {
            InitializeComponent();
        }
        public frmAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Articulo nuevoArticulo = new Articulo(); // comentado por que se simplifica el el tema de agregar y se recicla para crear el modificar
            ArticuloDB artDB = new ArticuloDB();

            try
            {
                if (articulo == null) { articulo = new Articulo(); }
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.ImagenUrl = txtImagen.Text;
                articulo.Marca = (Marcas)cbMarca.SelectedItem;
                articulo.Categoria = (Categorias)cbCategoria.SelectedItem;

                if (articulo.Id != 0)
                {
                    artDB.modificar(articulo);
                    MessageBox.Show("Articulo Modificado");
                }
                else
                {
                    artDB.agregar(articulo);
                    MessageBox.Show("Artículo agregado");
                }


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
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";
                cbCategoria.DataSource = categoriaDB.listar();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtImagen.Text = articulo.ImagenUrl;
                    cargarImagen(txtImagen.Text);
                    cbMarca.SelectedValue = articulo.Marca.Id;
                    cbCategoria.SelectedValue = articulo.Categoria.Id;
                }
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