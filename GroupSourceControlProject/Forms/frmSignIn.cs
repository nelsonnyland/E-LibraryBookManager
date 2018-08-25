using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupSourceControlProject
{
    public partial class FrmSignIn : Form
    {
        public FrmSignIn()
        {
            InitializeComponent();
        }

        public void BtnSubmit_Click(object sender, EventArgs e)
        {
            Member member = new Member();

            Random random = new Random();

            member.Username = txtUsername2.Text;

            member.PIN = Convert.ToInt32(txtPIN2.Text);

            member.LastName = txtLastName.Text;

            member.FirstName = txtFirstName.Text;

            MemberDB.Register(member);
        }

        public void BtnSignIn_Click(object sender, EventArgs e)
        {
            Member member = new Member();

            member.Username = txtUsername.Text;

            member.PIN =
                Convert.ToInt32(txtPIN.Text);

            if (MemberDB.IsMember(member))
            {
                MemberDB.LogIn(member);

                this.Hide();

                FrmLibrary addLibraryForm = new FrmLibrary();

                addLibraryForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Not a library member.", "Error");

                txtUsername.Text = string.Empty;

                txtPIN.Text = string.Empty;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
