using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EOMOD.Controllers;
using EOMOD.Views;

namespace EOMOD
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();

            DialogResult = DialogResult.Abort;
            toolStripStatusLabel2.Text = Auth.StatusBar;
            statusStrip1.Refresh();
        } 

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void listadoDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenSearchStudents();
        }

        private void OpenSearchStudents()
        {
            frmSearchStudents philter = new frmSearchStudents();
            if (philter.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void OpenSearchDetailStudents()
        {
            DetalleStudents Detail = new DetalleStudents();
            if (Detail.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void OpenListStudents()
        {
            ListStudents listStudents = new ListStudents();
            if (listStudents.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void OpenUpdateStudents()
        {
            UpdateStudents updateStudents = new UpdateStudents();
            if (updateStudents.ShowDialog() == DialogResult.OK)
            {

            }
        }


        private void detalleDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenSearchDetailStudents();
        }

        private void listadoAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenListStudents();
        }

        private void agregarFotografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenUpdateStudents();
        }
    }
}
