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
            ReloadPage();
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            List<Book> books = MemberDB.GetMemberBooks();
            
            if (books != null)
            {
                var checkedItems = chkListCheckedOut.CheckedItems;

                List<Book> selected = new List<Book>();

                foreach (Book b in books)
                {
                    // suspect code //
                    if (checkedItems.Contains(b))
                        selected.Add(b);
                }

                LibraryDB.CheckInBooks(selected);
            }
            else
            {
                MessageBox.Show("Nothing to check-in.");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var selectedItem = cboBooksAvail.SelectedItem;

            if (selectedItem != null)
                lstSelectedBooks.Items.Add(selectedItem);
            else
                MessageBox.Show("Please select an item.");
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            var selectedItems = lstSelectedBooks.Items;

            if (selectedItems.Count > 0)
            {
                List<Book> uncheckedBooks =
                    LibraryDB.GetAllUncheckedBooks();

                List<Book> selectedBooks = new List<Book>();

                for (int i = 0; i < selectedItems.to; i++)
                {

                }

                foreach (Book b in uncheckedBooks)
                {
                    // DEBUG //
                    if (selectedItems.Contains(b))
                        selectedBooks.Add(b);
                }

                if (LibraryDB.CheckoutBooks(selectedBooks))
                {
                    MessageBox.Show("Check-Out Successful.");

                    ReloadPage();
                }
                else
                {
                    MessageBox.Show("Check-Out Unsuccessful.");
                }
            }
            else
            {
                MessageBox.Show("Nothing to check-out");
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReloadPage()
        {
            chkListCheckedOut.Items.Clear();
            
            List<Book> checkedBooks =
                MemberDB.GetMemberBooks();

            if (checkedBooks != null)
            {
                foreach (Book b in checkedBooks)
                {
                    chkListCheckedOut.Items.Add($"{b.Title},  " +
                            $"{b.Author},  {b.PubDate},  " +
                            $"{b.Category}");
                }
            }

            cboBooksAvail.Items.Clear();

            List<Book> uncheckedBooks =
                LibraryDB.GetAllUncheckedBooks();

            if (uncheckedBooks != null)
            {
                foreach (Book b in uncheckedBooks)
                {
                    cboBooksAvail.Items.Add($"{b.Title},  " +
                            $"{b.Author},  {b.PubDate},  " +
                            $"{b.Category}");
                }
            }

            lstSelectedBooks.Items.Clear();
        }
    }
}
