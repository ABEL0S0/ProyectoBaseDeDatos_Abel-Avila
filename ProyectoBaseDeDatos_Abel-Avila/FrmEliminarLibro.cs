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
    public partial class FrmEliminarLibro : Form
    {
        public FrmEliminarLibro()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.txtNombreLibro.Clear();
            this.txtAutor.Clear();
            this.txtFechaCompra.Clear();
            this.txtPrecioCompra.Clear();
            this.txtUnidades.Clear();
            this.txtFechaCreacion.Clear();
            this.btnEliminar.Enabled = true;
            ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.LibrosDAO oEst =
                    new ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.LibrosDAO();

            string CodigoLibro = this.txtCodigoLibro.Text;
            DataTable dt = oEst.getLibro(CodigoLibro);
            //recorro los datos recuperados
            foreach (DataRow fila in dt.Rows)
            {
                this.txtNombreLibro.Text = fila["NombreLibro"].ToString();
                this.txtAutor.Text = fila["Autor"].ToString();
                this.txtPrecioCompra.Text = fila["PrecioCompra"].ToString();
                this.txtFechaCompra.Text = Convert.ToDateTime(fila["FechaCompra"].ToString()).ToString("dd/MM/yyyy");
                //tarea: mostrar solo 2 decimales
                this.txtUnidades.Text = fila["Unidades"].ToString();
                this.txtFechaCreacion.Text = fila["FechaCreacion"].ToString();
            }
            //tarea: muestre el mensaje adecuado, en caso que el estudiante no exista
            if (this.txtNombreLibro.TextLength == (0) || this.txtAutor.TextLength == (0) || this.txtFechaCompra.TextLength == (0) || this.txtUnidades.TextLength == (0) || this.txtFechaCreacion.TextLength == (0) || this.txtCodigoLibro.Text == "0000000000")
            {
                MessageBox.Show("El Libro buscado no Existe");
                this.btnEliminar.Enabled = false;
                return;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult reultado = MessageBox.Show("¿Estas seguro de que quieres eliminar al estudiante?", "Confirmar", MessageBoxButtons.YesNo);
            if (reultado == DialogResult.Yes)
            {
                string CodigoLibro = this.txtCodigoLibro.Text;
                ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.LibrosDAO oEst
                    = new ProyectoBaseDeDatos_Abel_Avila.DATA_ACCess_OBJECT.LibrosDAO();
                int x = oEst.eliminar(CodigoLibro);
                if (x > 0)
                { MessageBox.Show("Registro eliminado con exito"); }
                else
                { MessageBox.Show("No se pudo eliminar el registro"); }
                this.txtNombreLibro.Clear();
                this.txtAutor.Clear();
                this.txtFechaCompra.Clear();
                this.txtPrecioCompra.Clear();
                this.txtUnidades.Clear();
                this.txtFechaCreacion.Clear();
                this.txtCodigoLibro.Text = "0000000000";
            }
            else if (reultado == DialogResult.No)
            {
                return;
            }
        }
    }
}
