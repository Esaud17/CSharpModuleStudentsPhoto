namespace EOMOD.Views
{
    partial class ListStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListStudents));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlRegistroCode = new System.Windows.Forms.Panel();
            this.lblRegistroCode = new System.Windows.Forms.Label();
            this.txbRegistroCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlRegistroCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 438);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(686, 438);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnViewDetail);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.pnlRegistroCode);
            this.panel2.Controls.Add(this.txbRegistroCode);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 45);
            this.panel2.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(425, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Limpiar Filtros";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlRegistroCode
            // 
            this.pnlRegistroCode.BackColor = System.Drawing.Color.DimGray;
            this.pnlRegistroCode.Controls.Add(this.lblRegistroCode);
            this.pnlRegistroCode.Location = new System.Drawing.Point(12, 12);
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
            this.txbRegistroCode.Location = new System.Drawing.Point(77, 12);
            this.txbRegistroCode.Name = "txbRegistroCode";
            this.txbRegistroCode.Size = new System.Drawing.Size(230, 20);
            this.txbRegistroCode.TabIndex = 8;
            this.txbRegistroCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbRegistroCode.TextChanged += new System.EventHandler(this.txbRegistroCode_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(313, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(685, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetail.Location = new System.Drawing.Point(565, 10);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(106, 23);
            this.btnViewDetail.TabIndex = 13;
            this.btnViewDetail.Text = "Ver Ficha";
            this.btnViewDetail.UseVisualStyleBackColor = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // ListStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 514);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(701, 553);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(701, 553);
            this.Name = "ListStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListStudents";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlRegistroCode.ResumeLayout(false);
            this.pnlRegistroCode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlRegistroCode;
        private System.Windows.Forms.Label lblRegistroCode;
        private System.Windows.Forms.TextBox txbRegistroCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnViewDetail;
    }
}