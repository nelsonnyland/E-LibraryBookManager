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

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            Member member = new Member();

            member.CardNumber = 
                Convert.ToInt32(txtCardNumber.Text);

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

                txtCardNumber.Text = string.Empty;

                txtPIN.Text = string.Empty;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
