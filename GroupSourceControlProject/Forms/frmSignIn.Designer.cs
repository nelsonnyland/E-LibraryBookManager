namespace GroupSourceControlProject
{
    partial class FrmSignIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpSignIn = new System.Windows.Forms.GroupBox();
            this.grpRegister = new System.Windows.Forms.GroupBox();
            this.txtUsername2 = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPIN2 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSignIn.SuspendLayout();
            this.grpRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(89, 28);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(212, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PIN";
            // 
            // txtPIN
            // 
            this.txtPIN.AcceptsReturn = true;
            this.txtPIN.Location = new System.Drawing.Point(89, 69);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(42, 20);
            this.txtPIN.TabIndex = 1;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(226, 113);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Sign-In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(132, 113);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // grpSignIn
            // 
            this.grpSignIn.Controls.Add(this.txtUsername);
            this.grpSignIn.Controls.Add(this.txtPIN);
            this.grpSignIn.Controls.Add(this.btnCancel);
            this.grpSignIn.Controls.Add(this.btnSignIn);
            this.grpSignIn.Controls.Add(this.label1);
            this.grpSignIn.Controls.Add(this.label2);
            this.grpSignIn.Location = new System.Drawing.Point(25, 259);
            this.grpSignIn.Name = "grpSignIn";
            this.grpSignIn.Size = new System.Drawing.Size(319, 156);
            this.grpSignIn.TabIndex = 1;
            this.grpSignIn.TabStop = false;
            this.grpSignIn.Text = "Sign-In";
            // 
            // grpRegister
            // 
            this.grpRegister.Controls.Add(this.txtUsername2);
            this.grpRegister.Controls.Add(this.txtFirstName);
            this.grpRegister.Controls.Add(this.txtLastName);
            this.grpRegister.Controls.Add(this.txtPIN2);
            this.grpRegister.Controls.Add(this.btnSubmit);
            this.grpRegister.Controls.Add(this.label6);
            this.grpRegister.Controls.Add(this.label5);
            this.grpRegister.Controls.Add(this.label3);
            this.grpRegister.Controls.Add(this.label4);
            this.grpRegister.Location = new System.Drawing.Point(25, 23);
            this.grpRegister.Name = "grpRegister";
            this.grpRegister.Size = new System.Drawing.Size(319, 230);
            this.grpRegister.TabIndex = 0;
            this.grpRegister.TabStop = false;
            this.grpRegister.Text = "Register";
            // 
            // txtUsername2
            // 
            this.txtUsername2.Location = new System.Drawing.Point(89, 29);
            this.txtUsername2.Name = "txtUsername2";
            this.txtUsername2.Size = new System.Drawing.Size(212, 20);
            this.txtUsername2.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(89, 65);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(212, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(89, 102);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(212, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtPIN2
            // 
            this.txtPIN2.AcceptsReturn = true;
            this.txtPIN2.Location = new System.Drawing.Point(89, 139);
            this.txtPIN2.Name = "txtPIN2";
            this.txtPIN2.Size = new System.Drawing.Size(40, 20);
            this.txtPIN2.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(226, 184);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name";
            // 
            // FrmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(368, 437);
            this.Controls.Add(this.grpRegister);
            this.Controls.Add(this.grpSignIn);
            this.Name = "FrmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Library";
            this.grpSignIn.ResumeLayout(false);
            this.grpSignIn.PerformLayout();
            this.grpRegister.ResumeLayout(false);
            this.grpRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpSignIn;
        private System.Windows.Forms.GroupBox grpRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPIN2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername2;
        private System.Windows.Forms.Label label6;
    }
}

