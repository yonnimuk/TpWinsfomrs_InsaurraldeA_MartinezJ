﻿using System;
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
    public partial class Form1 : Form
    {
        private List<Articulo> articuloLista;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            ArticuloDB articulo = new ArticuloDB();
            try
            {
                articuloLista = articulo.listaArticulo();
                dataGridView1.DataSource = articuloLista;
                dataGridView1.Columns["ImagenUrl"].Visible = false;
                cargarImagen(articuloLista[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

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
            catch (Exception ex)
            {
                pxbArticulos.Load("https://www.trecebits.com/wp-content/uploads/2020/11/Error-404.jpg");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();
            cargar();
        }
    }
}
