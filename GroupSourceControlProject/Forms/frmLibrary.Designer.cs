namespace GroupSourceControlProject
{
    partial class FrmLibrary
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
            this.chkListCheckedOut = new System.Windows.Forms.CheckedListBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkListBooksSelected = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboBooksAvail = new System.Windows.Forms.ComboBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Books Checked Out:";
            // 
            // chkListCheckedOut
            // 
            this.chkListCheckedOut.FormattingEnabled = true;
            this.chkListCheckedOut.Location = new System.Drawing.Point(36, 57);
            this.chkListCheckedOut.Name = "chkListCheckedOut";
            this.chkListCheckedOut.Size = new System.Drawing.Size(383, 109);
            this.chkListCheckedOut.TabIndex = 2;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(441, 57);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(75, 23);
            this.btnCheckIn.TabIndex = 3;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(441, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(441, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chkListBooksSelected
            // 
            this.chkListBooksSelected.FormattingEnabled = true;
            this.chkListBooksSelected.Location = new System.Drawing.Point(36, 297);
            this.chkListBooksSelected.Name = "chkListBooksSelected";
            this.chkListBooksSelected.Size = new System.Drawing.Size(383, 109);
            this.chkListBooksSelected.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Books Selected:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Books Available:";
            // 
            // cboBooksAvail
            // 
            this.cboBooksAvail.FormattingEnabled = true;
            this.cboBooksAvail.Location = new System.Drawing.Point(36, 217);
            this.cboBooksAvail.Name = "cboBooksAvail";
            this.cboBooksAvail.Size = new System.Drawing.Size(383, 21);
            this.cboBooksAvail.TabIndex = 9;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(441, 297);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 10;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // frmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkListCheckedOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboBooksAvail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkListBooksSelected);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmLibrary";
            this.Text = "frmLibrary";
            this.Load += new System.EventHandler(this.FrmLibrary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkListCheckedOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckedListBox chkListBooksSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboBooksAvail;
        private System.Windows.Forms.Button btnCheckOut;
    }
}