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
    public partial class frmEliminar : Form
    {
        private Articulo art = null;
        public frmEliminar()
        {
            InitializeComponent();
        }
        public frmEliminar(Articulo elimArticulo)
        {
            InitializeComponent();
            art = elimArticulo;
            lblEliminar.Text = "¿Desea eliminar el artículo " + (string)art.Nombre + "?";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloDB artDB = new ArticuloDB();

            try
            {
                artDB.eliminar(art);
                MessageBox.Show("Artículo eliminado");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
