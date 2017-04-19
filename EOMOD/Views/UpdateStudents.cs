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
    public partial class UpdateStudents : Form
    {
        StudentsController ctrStudentds = new StudentsController();
        private Image vimage;
        public UpdateStudents()
        {
            InitializeComponent();
            if (Validations.DisticnNullEmptyWhiteSpace(StudentsModels.Code))
            {   
                txbRegistroCode.Text = StudentsModels.Code;
                btnSearch.Visible = false;
                txbRegistroCode.ReadOnly = true;

                loadData();
            }
            else
            {
                toolStripStatusLabel1.Text = "No hay registro cargados";
                toolStripStatusLabel1.Image = null;
                statusStrip1.Refresh();
            }
            txbFotografia.Visible = false;
            pnlFoto.Visible = false;
            DialogResult = DialogResult.OK;
           
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
            try
            {
                pctAlumno.Image = (Image)converter.ConvertFrom(ctrStudentds.Fotografia);
            }
            catch (Exception ex)
            {
                pctAlumno.Image = null;
            }

            valiteImage();
        }

        private void valiteImage()
        {
            if (Validations.DisticnNullEmptyWhiteSpace(ctrStudentds.Pnombre))
            {
                if (pctAlumno.Image != null)
                {
                    toolStripStatusLabel1.Text = "No hay cambios";
                    toolStripStatusLabel1.Image = null;
                }
                else
                {
                    toolStripStatusLabel1.Text = "Sin fotografía asignada";
                    toolStripStatusLabel1.Image = Properties.Resources.PoinInactive;
                }

                statusStrip1.Refresh();
            }
        }
        private void btnFotografia_Click(object sender, EventArgs e)
        {
            if (Validations.DisticnNullEmptyWhiteSpace(ctrStudentds.Pnombre))
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.txbFotografia.Text = openFileDialog1.FileName;
                    vimage = Image.FromFile(this.txbFotografia.Text);
                    vimage = Validations.ScaleImage(vimage, 300, 400);
                    pctAlumno.Image = vimage;
                    txbFotografia.Visible = true;
                    pnlFoto.Visible = true;

                    toolStripStatusLabel1.Text = "Hay cambios sin aplicar";
                    toolStripStatusLabel1.Image = Properties.Resources.PoinInactive;
                    statusStrip1.Refresh();
                }
            }
            else
            {
                MessageBox.Show(this, "No se ha encontrado un registro cargado", "Confirmación de registro ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbRegistroCode.Focus();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validations.DisticnNullEmptyWhiteSpace(txbFotografia.Text) && Validations.DisticnNullEmptyWhiteSpace(ctrStudentds.Pnombre))
            {
                MemoryStream stream = new MemoryStream();
                try
                {
                    this.pctAlumno.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {
                    ctrStudentds.Fotografia = null;
                }
                finally
                {
                    ctrStudentds.Fotografia = stream.GetBuffer();
                }
                ctrStudentds.UpdateByRegistroCode(ctrStudentds.Registro, ctrStudentds.Fotografia);

                txbFotografia.Text = String.Empty;
                txbFotografia.Visible = false;
                pnlFoto.Visible = false;

                toolStripStatusLabel1.Text = "No hay cambios";
                toolStripStatusLabel1.Image = null;
                statusStrip1.Refresh();

                MessageBox.Show(this, "Actualización de fotografía realizada", "Confirmación de registro ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!Validations.DisticnNullEmptyWhiteSpace(txbFotografia.Text))
            {
                MessageBox.Show(this, "No se ha selecionado una fotografía", "Confirmación de registro ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(!Validations.DisticnNullEmptyWhiteSpace(ctrStudentds.Pnombre))
            {
                MessageBox.Show(this, "No se ha encontrado un registro cargado", "Confirmación de registro ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void txbRegistroCode_TextChanged(object sender, EventArgs e)
        {
            String RegistroCode = Validations.DeleteCharters(txbRegistroCode.Text);

            this.txbRegistroCode.Text = RegistroCode;
            ctrStudentds.Registro = RegistroCode;
        }

        private void UpdateStudents_FormClosed(object sender, FormClosedEventArgs e)
        {
            StudentsController.Code = String.Empty;
            StudentsModels.GetCode = false;
        }
    }
}
