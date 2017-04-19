namespace EOMOD.Views
{
    partial class UpdateStudents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStudents));
            this.pnlRegistroCode = new System.Windows.Forms.Panel();
            this.lblRegistroCode = new System.Windows.Forms.Label();
            this.txbRegistroCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbGenero = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFotografia = new System.Windows.Forms.Button();
            this.pnlFoto = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txbFotografia = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pctAlumno = new System.Windows.Forms.PictureBox();
            this.pnlRegistroCode.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlFoto.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegistroCode
            // 
            this.pnlRegistroCode.BackColor = System.Drawing.Color.DimGray;
            this.pnlRegistroCode.Controls.Add(this.lblRegistroCode);
            this.pnlRegistroCode.Location = new System.Drawing.Point(19, 12);
            this.pnlRegistroCode.Name = "pnlRegistroCode";
            this.pnlRegistroCode.Size = new System.Drawing.Size(68, 20);
            this.pnlRegistroCode.TabIndex = 9;
            // 
            // lblRegistroCode
            // 
            this.lblRegistroCode.AutoSize = true;
            this.lblRegistroCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRegistroCode.Location = new System.Drawing.Point(13, 3);
            this.lblRegistroCode.Name = "lblRegistroCode";
            this.lblRegistroCode.Size = new System.Drawing.Size(46, 13);
            this.lblRegistroCode.TabIndex = 4;
            this.lblRegistroCode.Text = "Registro";
            // 
            // txbRegistroCode
            // 
            this.txbRegistroCode.Location = new System.Drawing.Point(84, 12);
            this.txbRegistroCode.Name = "txbRegistroCode";
            this.txbRegistroCode.Size = new System.Drawing.Size(154, 20);
            this.txbRegistroCode.TabIndex = 8;
            this.txbRegistroCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbRegistroCode.TextChanged += new System.EventHandler(this.txbRegistroCode_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(248, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(19, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 20);
            this.panel3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(84, 38);
            this.txbName.Name = "txbName";
            this.txbName.ReadOnly = true;
            this.txbName.Size = new System.Drawing.Size(270, 20);
            this.txbName.TabIndex = 11;
            this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(19, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 20);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Genero";
            // 
            // txbGenero
            // 
            this.txbGenero.Location = new System.Drawing.Point(84, 64);
            this.txbGenero.Name = "txbGenero";
            this.txbGenero.ReadOnly = true;
            this.txbGenero.Size = new System.Drawing.Size(270, 20);
            this.txbGenero.TabIndex = 13;
            this.txbGenero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFotografia
            // 
            this.btnFotografia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotografia.Location = new System.Drawing.Point(248, 88);
            this.btnFotografia.Name = "btnFotografia";
            this.btnFotografia.Size = new System.Drawing.Size(106, 23);
            this.btnFotografia.TabIndex = 20;
            this.btnFotografia.Text = "Fotografía";
            this.btnFotografia.UseVisualStyleBackColor = true;
            this.btnFotografia.Click += new System.EventHandler(this.btnFotografia_Click);
            // 
            // pnlFoto
            // 
            this.pnlFoto.BackColor = System.Drawing.Color.DimGray;
            this.pnlFoto.Controls.Add(this.label3);
            this.pnlFoto.Location = new System.Drawing.Point(19, 90);
            this.pnlFoto.Name = "pnlFoto";
            this.pnlFoto.Size = new System.Drawing.Size(68, 20);
            this.pnlFoto.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Imagen";
            // 
            // txbFotografia
            // 
            this.txbFotografia.Location = new System.Drawing.Point(84, 90);
            this.txbFotografia.Name = "txbFotografia";
            this.txbFotografia.ReadOnly = true;
            this.txbFotografia.Size = new System.Drawing.Size(154, 20);
            this.txbFotografia.TabIndex = 18;
            this.txbFotografia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(19, 430);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(335, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(371, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // pctAlumno
            // 
            this.pctAlumno.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pctAlumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctAlumno.Location = new System.Drawing.Point(57, 117);
            this.pctAlumno.Name = "pctAlumno";
            this.pctAlumno.Size = new System.Drawing.Size(250, 300);
            this.pctAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAlumno.TabIndex = 0;
            this.pctAlumno.TabStop = false;
            // 
            // UpdateStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 488);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnFotografia);
            this.Controls.Add(this.pnlFoto);
            this.Controls.Add(this.txbFotografia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbGenero);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pnlRegistroCode);
            this.Controls.Add(this.txbRegistroCode);
            this.Controls.Add(this.pctAlumno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(387, 527);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(387, 527);
            this.Name = "UpdateStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actulizar Fotografía";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateStudents_FormClosed);
            this.pnlRegistroCode.ResumeLayout(false);
            this.pnlRegistroCode.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFoto.ResumeLayout(false);
            this.pnlFoto.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctAlumno;
        private System.Windows.Forms.Panel pnlRegistroCode;
        private System.Windows.Forms.Label lblRegistroCode;
        private System.Windows.Forms.TextBox txbRegistroCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbGenero;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFotografia;
        private System.Windows.Forms.Panel pnlFoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbFotografia;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}