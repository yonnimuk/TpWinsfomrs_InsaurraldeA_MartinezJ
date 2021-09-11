using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public partial class Form1 : Form
    {
        private List<Articulo> articuloLista;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloDB articulo = new ArticuloDB();
            articuloLista = articulo.listaArticulo();
            dataGridView1.DataSource = articuloLista;
            cargarImagen(articuloLista[0].ImagenUrl);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
             Articulo articuloSeleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
             cargarImagen(articuloSeleccionado.ImagenUrl);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pxbArticulos.Load(imagen);
            }
            catch (Exception)
            {
                pxbArticulos.Load("https://www.trecebits.com/wp-content/uploads/2020/11/Error-404.jpg");
            }
        }

    }
}
