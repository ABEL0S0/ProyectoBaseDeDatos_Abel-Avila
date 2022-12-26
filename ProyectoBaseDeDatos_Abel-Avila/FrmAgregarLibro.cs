﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBaseDeDatos_Abel_Avila
{
    public partial class FrmAgregarLibro : Form
    {
        public FrmAgregarLibro()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigoLibro.TextLength == (0) || this.txtNombreLibro.TextLength == (0) || this.txtPrecioCompra.TextLength == (0) || this.txtUnidades.TextLength == (0) || this.txtAutor.TextLength == (0))
            {
                MessageBox.Show("Ingrese los datos en todos los campos");
                return;
            }
            try
            {
                ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.Libro est =
                    new ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.Libro();
                est.CodigoLibro = this.txtCodigoLibro.Text;
                est.NombreLibro = this.txtNombreLibro.Text;
                est.Autor = this.txtAutor.Text;
                est.PrecioCompra = float.Parse(this.txtPrecioCompra.Text);
                est.FechaCompra = this.dtFechaCompra.Value;
                est.Unidades = Int32.Parse(this.txtUnidades.Text);

                ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.LibrosDAO objLibro =
                    new ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.LibrosDAO();
                //llamo al metodo para guardar el registro
                int X = objLibro.guardar(est);
                if (X > 0)
                    MessageBox.Show("Libro agregado con exito.");
                else
                    MessageBox.Show("No se pudo agregar el Libro.");
            }
            catch (Exception x)
            { MessageBox.Show(x.Message.ToString()); }
            this.txtCodigoLibro.Clear();
            this.txtNombreLibro.Clear();
            this.txtAutor.Clear();
            this.txtPrecioCompra.Clear();
            this.dtFechaCompra.Value = DateTime.Now;
            this.txtUnidades.Clear();
        }
    }
}
