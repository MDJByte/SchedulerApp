namespace SchedulerApp
{
    partial class Form1
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
            this.lbUserName = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(686, 170);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(152, 32);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(612, 244);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(329, 35);
            this.txtUser.TabIndex = 1;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(688, 351);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(146, 32);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(612, 441);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(329, 26);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(692, 560);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(142, 53);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 812);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogIn;
    }
}

