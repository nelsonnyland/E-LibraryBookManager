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

            if (SubmissionCorrect())
            {
                member.Username = txtUsername2.Text;

                member.PIN = Convert.ToInt32(txtPIN2.Text);

                member.LastName = txtLastName.Text;

                member.FirstName = txtFirstName.Text;

                if (MemberDB.IsMember(member))
                {
                    MessageBox.Show("Already a member. Sign-in below.");
                }
                else
                {
                    if (MemberDB.Register(member))
                        MessageBox.Show("Registration successful.");
                    else
                        MessageBox.Show("Registration failed. Try again.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect submission. " +
                                "Please try again.");
            }

            Clear();
        }

        public void BtnSignIn_Click(object sender, EventArgs e)
        {
            Member member = new Member();

            if (!Empty(txtUsername.Text))
                member.Username = txtUsername.Text;

            if (!InvalidInt(txtPIN.Text))
                member.PIN = Convert.ToInt32(txtPIN.Text);

            if (MemberDB.IsMember(member))
            {
                if (MemberDB.Validate(member))
                {
                    this.Hide();

                    FrmLibrary addLibraryForm = new FrmLibrary();

                    addLibraryForm.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("PIN incorrect. Try again.");
                }
            }
            else
            {
                MessageBox.Show("Not a library member.", "Error");
            }

            Clear();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static bool InvalidInt(string input)
        {
            if (!String.IsNullOrEmpty(input))
            {
                if (Int32.TryParse(input, out int test))
                {
                    // is valid
                    return false;
                }
            }
            // is invalid
            return true;
        }

        private static bool Empty(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                return true;
            }
            return false;
        }

        private bool SubmissionCorrect()
        {
            if (Empty(txtUsername2.Text))
                return false;

            if (InvalidInt(txtPIN2.Text))
                return false;

            if (Empty(txtUsername2.Text))
                return false;

            if (Empty(txtUsername2.Text))
                return false;

            return true;
        }

        private void Clear()
        {
            txtUsername2.Text = String.Empty;
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtPIN2.Text = String.Empty;
            txtUsername.Text = String.Empty;
            txtPIN.Text = String.Empty;
        }
    }
}
