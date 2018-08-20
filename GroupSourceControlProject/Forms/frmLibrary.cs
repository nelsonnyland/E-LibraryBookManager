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
    public partial class FrmLibrary : Form
    {
        public FrmLibrary()
        {
            InitializeComponent();
        }

        private void FrmLibrary_Load(object sender, EventArgs e)
        {
            // load checked-out books
            Member member = MemberDB.GetCurrentMember();

            List<Book> checkedBooks =
                MemberDB.GetAllMembersBooks(member);

            // load books available to check out
            List<Book> uncheckedBooks =
                LibraryDB.GetAllUncheckedBooks();

            foreach (Book b in uncheckedBooks)
            {
                cboBooksAvail.Items.Add(b.Title);
            }
        }
    }
}
