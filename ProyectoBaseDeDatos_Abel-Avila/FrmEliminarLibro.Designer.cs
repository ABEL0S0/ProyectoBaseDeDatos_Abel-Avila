namespace ProyectoBaseDeDatos_Abel_Avila
{
    partial class FrmEliminarLibro
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoLibro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFechaCreacion = new System.Windows.Forms.TextBox();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.txtFechaCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(394, 28);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 41);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(526, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 41);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(662, 28);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(126, 41);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el codigo del libro a eliminar";
            // 
            // txtCodigoLibro
            // 
            this.txtCodigoLibro.Location = new System.Drawing.Point(245, 39);
            this.txtCodigoLibro.MaxLength = 10;
            this.txtCodigoLibro.Name = "txtCodigoLibro";
            this.txtCodigoLibro.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoLibro.TabIndex = 4;
            this.txtCodigoLibro.Text = "0000000000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFechaCreacion);
            this.groupBox1.Controls.Add(this.txtUnidades);
            this.groupBox1.Controls.Add(this.txtFechaCompra);
            this.groupBox1.Controls.Add(this.txtPrecioCompra);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.txtNombreLibro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(37, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 312);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del libro";
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Location = new System.Drawing.Point(131, 215);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.ReadOnly = true;
            this.txtFechaCreacion.Size = new System.Drawing.Size(133, 20);
            this.txtFechaCreacion.TabIndex = 23;
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(86, 185);
            this.txtUnidades.MaxLength = 10;
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.ReadOnly = true;
            this.txtUnidades.Size = new System.Drawing.Size(100, 20);
            this.txtUnidades.TabIndex = 22;
            // 
            // txtFechaCompra
            // 
            this.txtFechaCompra.Location = new System.Drawing.Point(125, 153);
            this.txtFechaCompra.Name = "txtFechaCompra";
            this.txtFechaCompra.ReadOnly = true;
            this.txtFechaCompra.Size = new System.Drawing.Size(139, 20);
            this.txtFechaCompra.TabIndex = 21;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(125, 117);
            this.txtPrecioCompra.MaxLength = 10;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.ReadOnly = true;
            this.txtPrecioCompra.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioCompra.TabIndex = 20;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(66, 84);
            this.txtAutor.MaxLength = 60;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(159, 20);
            this.txtAutor.TabIndex = 19;
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(121, 45);
            this.txtNombreLibro.MaxLength = 60;
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.ReadOnly = true;
            this.txtNombreLibro.Size = new System.Drawing.Size(166, 20);
            this.txtNombreLibro.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha de Creacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Unidades";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha de Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Precio de Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre del Libro";
            // 
            // FrmEliminarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCodigoLibro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Name = "FrmEliminarLibro";
            this.Text = "Eliminar Libro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoLibro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFechaCreacion;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.TextBox txtFechaCompra;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}