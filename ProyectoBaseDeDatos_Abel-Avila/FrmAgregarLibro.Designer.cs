namespace ProyectoBaseDeDatos_Abel_Avila
{
    partial class FrmAgregarLibro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.txtCodigoLibro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.dtFechaCompra);
            this.groupBox1.Controls.Add(this.txtUnidades);
            this.groupBox1.Controls.Add(this.txtPrecioCompra);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.txtNombreLibro);
            this.groupBox1.Controls.Add(this.txtCodigoLibro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese Los datos del Libro";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(315, 281);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(204, 61);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(95, 281);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(204, 61);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtFechaCompra
            // 
            this.dtFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaCompra.Location = new System.Drawing.Point(103, 203);
            this.dtFechaCompra.Name = "dtFechaCompra";
            this.dtFechaCompra.Size = new System.Drawing.Size(92, 20);
            this.dtFechaCompra.TabIndex = 11;
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(64, 236);
            this.txtUnidades.MaxLength = 5;
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(67, 20);
            this.txtUnidades.TabIndex = 10;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(103, 160);
            this.txtPrecioCompra.MaxLength = 10;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(109, 20);
            this.txtPrecioCompra.TabIndex = 9;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(44, 129);
            this.txtAutor.MaxLength = 60;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(168, 20);
            this.txtAutor.TabIndex = 8;
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(99, 95);
            this.txtNombreLibro.MaxLength = 50;
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(157, 20);
            this.txtNombreLibro.TabIndex = 7;
            // 
            // txtCodigoLibro
            // 
            this.txtCodigoLibro.Location = new System.Drawing.Point(95, 65);
            this.txtCodigoLibro.MaxLength = 10;
            this.txtCodigoLibro.Name = "txtCodigoLibro";
            this.txtCodigoLibro.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoLibro.TabIndex = 6;
            this.txtCodigoLibro.Text = "0000000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Unidades";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Libro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del Libro";
            // 
            // FrmAgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAgregarLibro";
            this.Text = "Agregar Libro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtFechaCompra;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.TextBox txtCodigoLibro;
    }
}