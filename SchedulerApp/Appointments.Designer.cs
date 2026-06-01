namespace SchedulerApp
{
    partial class AppointmentForm
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
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lbAppoinments = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.Customer = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Label();
            this.End = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.dtFilterDate = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(550, 44);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(365, 28);
            this.cmbCustomer.TabIndex = 0;
            // 
            // lbAppoinments
            // 
            this.lbAppoinments.AutoSize = true;
            this.lbAppoinments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppoinments.Location = new System.Drawing.Point(634, 413);
            this.lbAppoinments.Name = "lbAppoinments";
            this.lbAppoinments.Size = new System.Drawing.Size(192, 32);
            this.lbAppoinments.TabIndex = 1;
            this.lbAppoinments.Text = "Appoinments";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(550, 110);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(365, 37);
            this.txtTitle.TabIndex = 2;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(550, 195);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(365, 35);
            this.txtType.TabIndex = 3;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(550, 285);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(365, 26);
            this.dtStart.TabIndex = 4;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(550, 369);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(365, 26);
            this.dtEnd.TabIndex = 5;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(419, 448);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.RowHeadersWidth = 62;
            this.dgvAppointments.RowTemplate.Height = 28;
            this.dgvAppointments.Size = new System.Drawing.Size(634, 150);
            this.dgvAppointments.TabIndex = 6;
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.Location = new System.Drawing.Point(648, 9);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(144, 32);
            this.Customer.TabIndex = 7;
            this.Customer.Text = "Customer";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(670, 75);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(74, 32);
            this.Title.TabIndex = 8;
            this.Title.Text = "Title";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(680, 160);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(81, 32);
            this.Type.TabIndex = 9;
            this.Type.Text = "Type";
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(680, 250);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(79, 32);
            this.Start.TabIndex = 10;
            this.Start.Text = "Start";
            // 
            // End
            // 
            this.End.AutoSize = true;
            this.End.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End.Location = new System.Drawing.Point(691, 324);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(68, 32);
            this.End.TabIndex = 11;
            this.End.Text = "End";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(419, 967);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 53);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(640, 967);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 53);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Update";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnnUpdate_Click);
            // 
            // delBtn
            // 
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Location = new System.Drawing.Point(915, 967);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(134, 53);
            this.delBtn.TabIndex = 14;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtFilterDate
            // 
            this.dtFilterDate.Location = new System.Drawing.Point(515, 620);
            this.dtFilterDate.Name = "dtFilterDate";
            this.dtFilterDate.Size = new System.Drawing.Size(418, 26);
            this.dtFilterDate.TabIndex = 15;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(550, 672);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 1050);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dtFilterDate);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lbAppoinments);
            this.Controls.Add(this.cmbCustomer);
            this.Name = "AppointmentForm";
            this.Text = "Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lbAppoinments;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Label Customer;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label End;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.DateTimePicker dtFilterDate;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}