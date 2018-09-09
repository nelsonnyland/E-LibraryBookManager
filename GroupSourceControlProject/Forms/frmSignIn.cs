using GroupSourceControlProject.Forms;
using GroupSourceControlProject.ObjClasses;
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

        public void Register(object sender, EventArgs e)
        {
            Member member = new Member();

            if (SubmissionCorrect())
            {
                member.MemberID = MemberDB.CreateMemberID();
                
                member.Username = txtUsername2.Text;

                member.PIN = Convert.ToInt32(txtPIN2.Text);

                member.LastName = txtLastName.Text;

                member.FirstName = txtFirstName.Text;

                if (chkAdmin.Checked is true)
                    member.IsAdmin = true;

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

        public void SignIn(object sender, EventArgs e)
        {
            Member member = new Member();

            if (!IsEmpty(txtUsername.Text))
                member.Username = txtUsername.Text;

            if (!InvalidInt(txtPIN.Text))
                member.PIN = Convert.ToInt32(txtPIN.Text);

            if (MemberDB.IsMember(member))
            {
                if (MemberDB.LogIn(member))
                {
                    Member dbMember = 
                        CurrentMember.GetCurrentMember();
                    
                    if (chkAdmin2.Checked is true &&
                        dbMember.IsAdmin is true)
                    {
                        this.Hide();

                        FrmAdmin addAdminForm = 
                            new FrmAdmin();

                        addAdminForm.ShowDialog();

                        this.Close();
                    }
                    else
                    {
                        this.Hide();

                        FrmLibrary addLibraryForm = 
                            new FrmLibrary();

                        addLibraryForm.ShowDialog();

                        this.Close();
                    }
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

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private static bool InvalidInt(string input)
        {
            if (!String.IsNullOrEmpty(input))
            {
                if (Int32.TryParse(input, out int test))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsEmpty(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                return true;
            }
            return false;
        }

        private bool SubmissionCorrect()
        {
            if (IsEmpty(txtUsername2.Text))
                return false;

            if (IsEmpty(txtFirstName.Text))
                return false;

            if (IsEmpty(txtLastName.Text))
                return false;

            if (InvalidInt(txtPIN2.Text))
                return false;

            return true;
        }

        private void Clear()
        {
            txtUsername2.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPIN2.Clear();
            chkAdmin.Checked = false;
            txtUsername.Clear();
            txtPIN.Clear();
            chkAdmin2.Checked = false;
        }
    }
}
