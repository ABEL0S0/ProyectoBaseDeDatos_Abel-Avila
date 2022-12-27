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
    public partial class FrmModificarLibro : Form
    {
        public FrmModificarLibro()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.txtNombreLibro.Clear();
            this.txtAutor.Clear();
            this.dtFechaCompra.Value = DateTime.Now;
            this.txtPrecioCompra.Clear();
            this.txtUnidades.Clear();
            this.txtFechaCreacion.Clear();
            this.btnModificar.Enabled = true;
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
                this.dtFechaCompra.Text = Convert.ToDateTime(fila["FechaCompra"].ToString()).ToString("dd/MM/yyyy");
                //tarea: mostrar solo 2 decimales
                this.txtUnidades.Text = fila["Unidades"].ToString();
                this.txtFechaCreacion.Text = fila["FechaCreacion"].ToString();
            }
            //tarea: muestre el mensaje adecuado, en caso que el estudiante no exista
            if (this.txtNombreLibro.TextLength == (0) || this.txtAutor.TextLength == (0) || this.txtUnidades.TextLength == (0) || this.txtFechaCreacion.TextLength == (0) || this.txtCodigoLibro.Text == "0000000000")
            {
                MessageBox.Show("El Libro buscado no Existe");
                this.btnModificar.Enabled = false;
                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigoLibro.TextLength == (0) || this.txtNombreLibro.TextLength == (0) || this.txtPrecioCompra.TextLength == (0) || this.txtUnidades.TextLength == (0) || this.txtAutor.TextLength == (0) || this.txtCodigoLibro.Text == "0000000000")
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
                int X = objLibro.actualizar(est);
                if (X > 0)
                    MessageBox.Show("Libro agregado con exito.");
                else
                    MessageBox.Show("No se pudo Modificar el Libro.");
            }
            catch (Exception x)
            { MessageBox.Show(x.Message.ToString()); }

            this.txtNombreLibro.Clear();
            this.txtAutor.Clear();
            this.txtPrecioCompra.Clear();
            this.dtFechaCompra.Value = DateTime.Now;
            this.txtUnidades.Clear();
            this.txtCodigoLibro.Text = "0000000000";
            this.btnModificar.Enabled = false;
        }
    }
}
