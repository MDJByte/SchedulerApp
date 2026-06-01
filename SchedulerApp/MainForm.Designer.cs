namespace SchedulerApp
{
    partial class MainForm
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
            this.lbDash = new System.Windows.Forms.Label();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDash
            // 
            this.lbDash.AutoSize = true;
            this.lbDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDash.Location = new System.Drawing.Point(683, 52);
            this.lbDash.Name = "lbDash";
            this.lbDash.Size = new System.Drawing.Size(229, 46);
            this.lbDash.TabIndex = 0;
            this.lbDash.Text = "DashBoard";
            // 
            // btnCustomers
            // 
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Location = new System.Drawing.Point(705, 187);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(194, 49);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnAppointments
            // 
            this.btnAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointments.Location = new System.Drawing.Point(705, 309);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(218, 52);
            this.btnAppointments.TabIndex = 2;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.UseVisualStyleBackColor = true;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(705, 416);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(207, 47);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(705, 533);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(207, 48);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 778);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnAppointments);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.lbDash);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDash;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
    }
}