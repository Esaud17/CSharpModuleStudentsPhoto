using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EOMOD.Settings;
using EOMOD.Models;
using EOMOD.Controllers;
using System.IO;

namespace EOMOD.Views
{
    public partial class DetalleStudents : Form
    {
        StudentsController ctrStudentds = new StudentsController();
        private Image vimage;

        public DetalleStudents()
        {
            InitializeComponent();

            if (Validations.DisticnNullEmptyWhiteSpace(StudentsModels.Code))
            {
                txbRegistroCode.Text = StudentsModels.Code;
                btnSearch.Visible = false;
                txbRegistroCode.ReadOnly = true;

                loadData();
            }
        }

        private void loadData()
        {
            DataTable Stu = ctrStudentds.FindByRegistroCode(this.txbRegistroCode.Text);

            foreach (DataRow row in Stu.Rows)
            {
                StudentsModels.Code = row["registro"].ToString();
                ctrStudentds.Registro = row["registro"].ToString();
                ctrStudentds.Pnombre = row["pnombre"].ToString();
                ctrStudentds.Snombre = row["snombre"].ToString();
                ctrStudentds.Papellido = row["papellido"].ToString();
                ctrStudentds.Sapellido = row["sapellido"].ToString();
                ctrStudentds.Sexo = row["sexo"].ToString();

                ctrStudentds.Telefono = row["telcasa"].ToString();
                ctrStudentds.Direccion = row["direccion"].ToString();
                ctrStudentds.Madre = row["nombrem"].ToString();
                ctrStudentds.Padre = row["nombrep"].ToString();

                ctrStudentds.MadreTelefono = row["telm"].ToString();
                ctrStudentds.PadreTelefono = row["telp"].ToString();

                try
                {
                    ctrStudentds.Fotografia = (Byte[])row["foto"];
                }
                catch (Exception ex)
                {
                    ctrStudentds.Fotografia = null;
                }

            }
            ImageConverter converter = new ImageConverter();

            txbName.Text = String.Format("{0} {1} {2} {3}", ctrStudentds.Pnombre, ctrStudentds.Snombre, ctrStudentds.Papellido, ctrStudentds.Sapellido);
            txbGenero.Text = ctrStudentds.Sexo;
            txbTelefono.Text = ctrStudentds.Telefono;
            txbDireccion.Text = ctrStudentds.Direccion;
            txbMadre.Text = ctrStudentds.Madre;
            txbMadreTel.Text = ctrStudentds.MadreTelefono;
            txbPadre.Text = ctrStudentds.Padre;
            txbPadreTel.Text = ctrStudentds.PadreTelefono;
            try
            {
                pctAlumno.Image = (Image)converter.ConvertFrom(ctrStudentds.Fotografia);
            }
            catch (Exception ex)
            {
                pctAlumno.Image = null;
            }
          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Validations.DisticnNullEmptyWhiteSpace(this.txbRegistroCode.Text))
            {
                loadData();
            }
            else
            {
                StudentsModels.GetCode = true;

                frmSearchStudents screenphilter = new frmSearchStudents();
                if (screenphilter.ShowDialog() == DialogResult.OK)
                {
                    StudentsModels.GetCode = false;
                    txbRegistroCode.Text = StudentsModels.Code;
                    loadData();
                }
            }
        }

        private void pctAlumno_Click(object sender, EventArgs e)
        {
            if (Validations.DisticnNullEmptyWhiteSpace(StudentsModels.Code))
            {
                UpdateStudents updateStudents = new UpdateStudents();
                updateStudents.ShowDialog();

                StudentsModels.Code = txbRegistroCode.Text;
                loadData();
            }

        }

        private void DetalleStudents_FormClosed(object sender, FormClosedEventArgs e)
        {
            StudentsController.Code = String.Empty;
            StudentsModels.GetCode = false;
        }
    }
}
