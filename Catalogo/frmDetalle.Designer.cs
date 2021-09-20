﻿
namespace Catalogo
{
    partial class frmDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.txtImagenUrl = new System.Windows.Forms.Label();
            this.pxbDetalle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pxbDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Location = new System.Drawing.Point(66, 53);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(64, 25);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "label1";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(66, 139);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(64, 25);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "label2";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.Location = new System.Drawing.Point(66, 224);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(64, 25);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.Text = "label3";
            this.txtDescripcion.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.AutoSize = true;
            this.txtMarca.Location = new System.Drawing.Point(66, 309);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(64, 25);
            this.txtMarca.TabIndex = 3;
            this.txtMarca.Text = "label4";
            // 
            // txtCategoria
            // 
            this.txtCategoria.AutoSize = true;
            this.txtCategoria.Location = new System.Drawing.Point(66, 394);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(64, 25);
            this.txtCategoria.TabIndex = 4;
            this.txtCategoria.Text = "label5";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoSize = true;
            this.txtPrecio.Location = new System.Drawing.Point(66, 466);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(64, 25);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.Text = "label6";
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.AutoSize = true;
            this.txtImagenUrl.Location = new System.Drawing.Point(66, 544);
            this.txtImagenUrl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(64, 25);
            this.txtImagenUrl.TabIndex = 6;
            this.txtImagenUrl.Text = "label7";
            // 
            // pxbDetalle
            // 
            this.pxbDetalle.Location = new System.Drawing.Point(709, 53);
            this.pxbDetalle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pxbDetalle.Name = "pxbDetalle";
            this.pxbDetalle.Size = new System.Drawing.Size(468, 456);
            this.pxbDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbDetalle.TabIndex = 7;
            this.pxbDetalle.TabStop = false;
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 635);
            this.Controls.Add(this.pxbDetalle);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle ";
            ((System.ComponentModel.ISupportInitialize)(this.pxbDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtDescripcion;
        private System.Windows.Forms.Label txtMarca;
        private System.Windows.Forms.Label txtCategoria;
        private System.Windows.Forms.Label txtPrecio;
        private System.Windows.Forms.Label txtImagenUrl;
        private System.Windows.Forms.PictureBox pxbDetalle;
    }
}