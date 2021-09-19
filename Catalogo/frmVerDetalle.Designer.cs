
namespace Catalogo
{
    partial class frmVerDetalle
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
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.Label();
            this.txtImagenUrl = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.Label();
            this.pxbDetalle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pxbDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(3, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(47, 13);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.Location = new System.Drawing.Point(3, 187);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(66, 13);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.Text = "Descripcion:";
            // 
            // txtMarca
            // 
            this.txtMarca.AutoSize = true;
            this.txtMarca.Location = new System.Drawing.Point(6, 145);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(40, 13);
            this.txtMarca.TabIndex = 3;
            this.txtMarca.Text = "Marca:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.AutoSize = true;
            this.txtCategoria.Location = new System.Drawing.Point(-3, 273);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(55, 13);
            this.txtCategoria.TabIndex = 4;
            this.txtCategoria.Text = "Categoria:";
            this.txtCategoria.Click += new System.EventHandler(this.txtCategoria_Click);
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.AccessibleDescription = "";
            this.txtImagenUrl.AccessibleName = "";
            this.txtImagenUrl.AutoEllipsis = true;
            this.txtImagenUrl.AutoSize = true;
            this.txtImagenUrl.Location = new System.Drawing.Point(1, 316);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(23, 13);
            this.txtImagenUrl.TabIndex = 5;
            this.txtImagenUrl.Text = "Url:";
            this.txtImagenUrl.Click += new System.EventHandler(this.txtImagenUrl_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoSize = true;
            this.txtPrecio.Location = new System.Drawing.Point(3, 230);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(49, 13);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.Text = "Precio: $";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Location = new System.Drawing.Point(3, 63);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(43, 13);
            this.txtCodigo.TabIndex = 8;
            this.txtCodigo.Text = "Codigo:";
            this.txtCodigo.Click += new System.EventHandler(this.txtCodigo_Click);
            // 
            // pxbDetalle
            // 
            this.pxbDetalle.Location = new System.Drawing.Point(212, 12);
            this.pxbDetalle.Name = "pxbDetalle";
            this.pxbDetalle.Size = new System.Drawing.Size(265, 286);
            this.pxbDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbDetalle.TabIndex = 9;
            this.pxbDetalle.TabStop = false;
            this.pxbDetalle.Click += new System.EventHandler(this.frmVerDetalle_Load);
            // 
            // frmVerDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 338);
            this.Controls.Add(this.pxbDetalle);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmVerDetalle";
            this.Text = "Ver detalles";
            this.Load += new System.EventHandler(this.frmVerDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pxbDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtDescripcion;
        private System.Windows.Forms.Label txtMarca;
        private System.Windows.Forms.Label txtCategoria;
        private System.Windows.Forms.Label txtPrecio;
        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.PictureBox pxbDetalle;
        private System.Windows.Forms.Label txtImagenUrl;
    }
}