namespace SchedulerApp
{
    partial class CustomerForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(775, 123);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(93, 32);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(655, 216);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(365, 42);
            this.txtName.TabIndex = 1;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(775, 320);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(125, 32);
            this.lbAddress.TabIndex = 2;
            this.lbAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(655, 408);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(365, 41);
            this.txtAddress.TabIndex = 3;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(775, 516);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(102, 32);
            this.lbPhone.TabIndex = 4;
            this.lbPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(655, 612);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(354, 37);
            this.txtPhone.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(523, 731);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 53);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(768, 731);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 53);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(977, 731);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 53);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(523, 888);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 62;
            this.dgvCustomers.RowTemplate.Height = 28;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(630, 150);
            this.dgvCustomers.TabIndex = 9;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 1050);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCustomers;
    }
}