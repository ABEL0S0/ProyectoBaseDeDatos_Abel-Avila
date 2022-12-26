using System;
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
    public partial class FrmModificarEstudiantes : Form
    {
        public FrmModificarEstudiantes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.txtApellidos.Clear();
            this.txtNombres.Clear();
            this.txtEstatura.Clear();
            this.txtPeso.Clear();
            ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.EstudianteDAO oEst =
                    new ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.EstudianteDAO();

            string matricula = this.txtMatricula.Text;
            DataTable dt = oEst.getEstudiante(matricula);
            //recorro los datos recuperados
            foreach (DataRow fila in dt.Rows)
            {
                this.txtApellidos.Text = fila["Apellidos"].ToString();
                this.txtNombres.Text = fila["Nombres"].ToString();
                this.txtEstatura.Text = fila["Estatura"].ToString();
                this.dtFechaNacimiento.Text = Convert.ToDateTime(fila["FechaNacimiento"].ToString()).ToString("dd/MM/yyyy");
                //tarea: mostrar solo 2 decimales
                this.txtPeso.Text = fila["Peso"].ToString();

            }
            //tarea: muestre el mensaje adecuado, en caso que el estudiante no exista
            if (this.txtApellidos.TextLength == (0) || this.txtEstatura.TextLength == (0) || this.txtMatricula.TextLength == (0) || this.txtNombres.TextLength == (0) || this.txtPeso.TextLength == (0))
            {
                MessageBox.Show("El Estudiante buscado no Existe", "Busqueda No Exitosa");
                return;
            }
            this.btnModificar.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.txtApellidos.TextLength == (0) || this.txtEstatura.TextLength == (0) || this.txtMatricula.TextLength == (0) || this.txtNombres.TextLength == (0) || this.txtPeso.TextLength == (0))
            {
                MessageBox.Show("Ingrese los datos en todos los campos");
                return;
            }
            try
            {
                ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.Estudiante est =
                    new ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.Estudiante();
                est.Matricula = this.txtMatricula.Text;
                est.Apellidos = this.txtApellidos.Text;
                est.Nombres = this.txtNombres.Text;
                est.Estatura = Int32.Parse(this.txtEstatura.Text);
                est.FechaNacimiento = this.dtFechaNacimiento.Value;
                est.Peso = float.Parse(this.txtPeso.Text);

                ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.EstudianteDAO objEstudiante =
                    new ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.EstudianteDAO();
                //llamo al metodo para guardar el registro
                int X = objEstudiante.actualizar(est);
                if (X > 0)
                    MessageBox.Show("Estudiante Modificado con exito.");
                else
                    MessageBox.Show("No se pudo modificar los datos del estudiante.");
            }
            catch (Exception x)
            { MessageBox.Show(x.Message.ToString()); }
            this.txtMatricula.Clear();
            this.txtApellidos.Clear();
            this.txtNombres.Clear();
            this.txtEstatura.Clear();
            this.dtFechaNacimiento.Value = DateTime.Now;
            this.txtPeso.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }    
}
