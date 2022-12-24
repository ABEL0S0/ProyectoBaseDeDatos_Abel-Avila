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
    public partial class FrmBusquedaEsturiante : Form
    {
        public FrmBusquedaEsturiante()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.txtApellidos.Clear();
            this.txtNombres.Clear();
            this.txtEstatura.Clear();
            this.txtFechaNacimiento.Clear() ;            
            this.txtPeso.Clear();
            this.txtFechaCreacion.Clear();
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
                this.txtFechaNacimiento.Text = Convert.ToDateTime(fila["FechaNacimiento"].ToString()).ToString("dd/MM/yyyy");
                //tarea: mostrar solo 2 decimales
                this.txtPeso.Text = fila["Peso"].ToString();
                this.txtFechaCreacion.Text = fila["FechaDeCreacion"].ToString();
                //tarea: muestre el mensaje adecuado, en caso que el estudiante no exista
            }
            if (this.txtApellidos.TextLength == (0) || this.txtEstatura.TextLength == (0) || this.txtMatricula.TextLength == (0) || this.txtNombres.TextLength == (0) || this.txtPeso.TextLength == (0))
            {
                MessageBox.Show("El Estudiante buscado no Existe");
                return;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
