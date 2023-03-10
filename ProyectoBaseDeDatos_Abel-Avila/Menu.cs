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
    public partial class Menu : Form
    {
        private int childFormNumber = 0;

        public Menu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //Declaro frm1 al formulario
            FrmAgregarEstudiantes frm3 = new FrmAgregarEstudiantes();
            //Formulario menu es el contenedor o el formulario padre
            frm3.MdiParent = this;
            //Muestra el formulario
            frm3.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            //Declaro frm1 al formulario
            FrmEliminarEstudiante frm2 = new FrmEliminarEstudiante();
            //Formulario menu es el contenedor o el formulario padre
            frm2.MdiParent = this;
            //Muestra el formulario
            frm2.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void printPreviewToolStripButton_Click(object sender, EventArgs e)
        {
            //Declaro frm1 al formulario
            FrmBusquedaEstudiante frm1 = new FrmBusquedaEstudiante();
            //Formulario menu es el contenedor o el formulario padre
            frm1.MdiParent = this;
            //Muestra el formulario
            frm1.Show();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //Declaro frm1 al formulario
            FrmModificarEstudiantes frm4 = new FrmModificarEstudiantes();
            //Formulario menu es el contenedor o el formulario padre
            frm4.MdiParent = this;
            //Muestra el formulario
            frm4.Show();
        }

        private void nuevoEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declaro frm1 al formulario
            FrmAgregarEstudiantes frm3 = new FrmAgregarEstudiantes();
            //Formulario menu es el contenedor o el formulario padre
            frm3.MdiParent = this;
            //Muestra el formulario
            frm3.Show();
        }

        private void buscarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declaro frm1 al formulario
            FrmBusquedaEstudiante frm1 = new FrmBusquedaEstudiante();
            //Formulario menu es el contenedor o el formulario padre
            frm1.MdiParent = this;
            //Muestra el formulario
            frm1.Show();
        }

        private void eliminarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declaro frm1 al formulario
            FrmEliminarEstudiante frm2 = new FrmEliminarEstudiante();
            //Formulario menu es el contenedor o el formulario padre
            frm2.MdiParent = this;
            //Muestra el formulario
            frm2.Show();
        }

        private void modificarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declaro frm1 al formulario
            FrmModificarEstudiantes frm4 = new FrmModificarEstudiantes();
            //Formulario menu es el contenedor o el formulario padre
            frm4.MdiParent = this;
            //Muestra el formulario
            frm4.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Declaro frm1 al formulario
            FrmAgregarLibro frm5 = new FrmAgregarLibro();
            //Formulario menu es el contenedor o el formulario padre
            frm5.MdiParent = this;
            //Muestra el formulario
            frm5.Show();
        }

        private void nuevoLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declaro frm1 al formulario
            FrmAgregarLibro frm5 = new FrmAgregarLibro();
            //Formulario menu es el contenedor o el formulario padre
            frm5.MdiParent = this;
            //Muestra el formulario
            frm5.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //Declaro frm1 al formulario
            FrmBuscarLibro frm6 = new FrmBuscarLibro();
            //Formulario menu es el contenedor o el formulario padre
            frm6.MdiParent = this;
            //Muestra el formulario
            frm6.Show();
        }

        private void buscarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declaro frm1 al formulario
            FrmBuscarLibro frm6 = new FrmBuscarLibro();
            //Formulario menu es el contenedor o el formulario padre
            frm6.MdiParent = this;
            //Muestra el formulario
            frm6.Show();
        }

        private void eliminarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declaro frm1 al formulario
            FrmEliminarLibro frm7 = new FrmEliminarLibro();
            //Formulario menu es el contenedor o el formulario padre
            frm7.MdiParent = this;
            //Muestra el formulario
            frm7.Show();            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //Declaro frm1 al formulario
            FrmEliminarLibro frm7 = new FrmEliminarLibro();
            //Formulario menu es el contenedor o el formulario padre
            frm7.MdiParent = this;
            //Muestra el formulario
            frm7.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //Declaro frm1 al formulario
            FrmModificarLibro frm8 = new FrmModificarLibro();
            //Formulario menu es el contenedor o el formulario padre
            frm8.MdiParent = this;
            //Muestra el formulario
            frm8.Show();
        }

        private void modificarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declaro frm1 al formulario
            FrmModificarLibro frm8 = new FrmModificarLibro();
            //Formulario menu es el contenedor o el formulario padre
            frm8.MdiParent = this;
            //Muestra el formulario
            frm8.Show();
        }
    }
}
