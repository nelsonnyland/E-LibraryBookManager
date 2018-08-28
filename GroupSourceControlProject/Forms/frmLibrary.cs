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
            LoadBoxes();
        }

        private void LoadBoxes()
        {
            chkListCheckedOut.Items.Clear();
            
            List<Book> checkedBooks =
                MemberDB.GetMemberBooks();

            if (checkedBooks != null)
            {
                foreach (Book b in checkedBooks)
                {
                    chkListCheckedOut.Items.Add($"{b.BookID}, " +
                                                $"{b.Title},  " +
                                                $"{b.Author},  " +
                                                $"{b.PubDate},  " +
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
                    cboBooksAvail.Items.Add($"{b.BookID}, " +
                                            $"{b.Title},  " +
                                            $"{b.Author},  " +
                                            $"{b.PubDate},  " +
                                            $"{b.Category}");
                }
            }

            lstSelectedBooks.Items.Clear();
        }

        // TODO: Handle selected listbox item 
        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            List<Book> memberBooks = MemberDB.GetMemberBooks();
            
            if (memberBooks != null)
            {
                var selectedItems = chkListCheckedOut.SelectedItems;

                List<Book> selectedBooks = GetSelectedBooks(
                    selectedItems, memberBooks);

                LibraryDB.CheckInBooks(selectedBooks);

                MessageBox.Show("Check-In Successful.");

                LoadBoxes();
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

        // TODO: Handle selected item as a string
        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            if (lstSelectedBooks.SelectedIndex != -1)
            {
                var selectedItems = lstSelectedBooks.SelectedItems;

                List<Book> uncheckedBooks =
                    LibraryDB.GetAllUncheckedBooks();

                List<Book> selectedBooks = GetSelectedBooks(
                    selectedItems, uncheckedBooks);

                if (LibraryDB.CheckoutBooks(selectedBooks))
                {
                    MessageBox.Show("Check-Out Successful.");

                    LoadBoxes();
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

        private List<Book> GetSelectedBooks(ListBox.
            SelectedObjectCollection selectedItems, List<Book> books)
        {
            List<string> stringIds = new List<string>();
            
            // get string book ids
            foreach (var item in selectedItems)
            {
                stringIds.Add(item.ToString().
                    Substring(0, item.ToString().IndexOf(",")));
            }

            List<int> BookIds = new List<int>();
            
            // get int book ids
            foreach (string item in stringIds)
            {
                BookIds.Add(Convert.ToInt32(item));
            }

            List<Book> selectedBooks = new List<Book>();
            
            // get selected book ids
            foreach (int id in BookIds)
            {
                foreach (Book b in books)
                {
                    if (b.BookID == id)
                        selectedBooks.Add(b);
                }
            }

            return selectedBooks;
        }
    }
}
