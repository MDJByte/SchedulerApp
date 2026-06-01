namespace SchedulerApp
{
    partial class ReportsForms
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
            this.lbReports = new System.Windows.Forms.Label();
            this.cmbReports = new System.Windows.Forms.ComboBox();
            this.btnLoadReports = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // lbReports
            // 
            this.lbReports.AutoSize = true;
            this.lbReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReports.Location = new System.Drawing.Point(894, 55);
            this.lbReports.Name = "lbReports";
            this.lbReports.Size = new System.Drawing.Size(120, 32);
            this.lbReports.TabIndex = 0;
            this.lbReports.Text = "Reports";
            // 
            // cmbReports
            // 
            this.cmbReports.FormattingEnabled = true;
            this.cmbReports.Location = new System.Drawing.Point(793, 186);
            this.cmbReports.Name = "cmbReports";
            this.cmbReports.Size = new System.Drawing.Size(329, 28);
            this.cmbReports.TabIndex = 1;
            // 
            // btnLoadReports
            // 
            this.btnLoadReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadReports.Location = new System.Drawing.Point(853, 289);
            this.btnLoadReports.Name = "btnLoadReports";
            this.btnLoadReports.Size = new System.Drawing.Size(178, 52);
            this.btnLoadReports.TabIndex = 2;
            this.btnLoadReports.Text = "Load";
            this.btnLoadReports.UseVisualStyleBackColor = true;
            this.btnLoadReports.Click += new System.EventHandler(this.btnLoadReport_Click);
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(685, 481);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersWidth = 62;
            this.dgvReports.RowTemplate.Height = 28;
            this.dgvReports.Size = new System.Drawing.Size(537, 157);
            this.dgvReports.TabIndex = 3;
            this.dgvReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.z);
            // 
            // ReportsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1781, 818);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.btnLoadReports);
            this.Controls.Add(this.cmbReports);
            this.Controls.Add(this.lbReports);
            this.Name = "ReportsForms";
            this.Text = "ReportsForms";
            this.Load += new System.EventHandler(this.ReportsForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbReports;
        private System.Windows.Forms.ComboBox cmbReports;
        private System.Windows.Forms.Button btnLoadReports;
        private System.Windows.Forms.DataGridView dgvReports;
    }
}