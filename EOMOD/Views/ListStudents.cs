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
using EOMOD.Settings;
using EOMOD.Models;

namespace EOMOD.Views
{
    public partial class ListStudents : Form
    {
        StudentsController ctrStudentds = new StudentsController();
        public ListStudents()
        {
            InitializeComponent();
            dataGridView1.DataSource = ctrStudentds.FindAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  ctrStudentds.FindByRegistroCode(txbRegistroCode.Text);
        }

        private void txbRegistroCode_TextChanged(object sender, EventArgs e)
        {
            String RegistroCode = Validations.DeleteCharters(txbRegistroCode.Text);
            this.txbRegistroCode.Text = RegistroCode;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctrStudentds.FindAll();
            txbRegistroCode.Text = String.Empty;
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            String registro = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            StudentsModels.Code = registro;

            DetalleStudents screendetail = new DetalleStudents();
            screendetail.ShowDialog();

            StudentsModels.Code = String.Empty;

        }
    }
}
