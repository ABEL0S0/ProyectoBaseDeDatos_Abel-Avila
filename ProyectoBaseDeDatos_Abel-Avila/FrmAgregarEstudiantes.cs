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
    public partial class FrmAgregarEstudiantes : Form
    {
        public FrmAgregarEstudiantes()
        {
            InitializeComponent();
        }

        private void btnGuadar_Click(object sender, EventArgs e)
        {
            try
            { }
            catch(Exception x)
            { MessageBox.Show(x.Message.ToString()); }
            ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.Estudiante est =
                new ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.Estudiante();
            est.Matricula = this.txtMatricula.Text;
            est.Apellidos = this.txtApellidos.Text;
            est.Nombres = this.txtNombres.Text;
            est.Estatura = Int32.Parse(this.txtEstatura.Text);
            est.FechaNacimiento=this.dtFechadenacimiento.Value;
            est.Peso = float.Parse(this.txtPeso.Text);

            ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.EstudianteDAO objEstudiante =
                new ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.EstudianteDAO();

        }
    }
}