using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Clears form and loads list boxes with data.
        /// </summary>
        private void LoadBoxes()
        {
            chkListCheckedOut.Items.Clear();
            
            List<Book> checkedBooks =
                LibraryDB.GetMemberBooks();

            if (checkedBooks != null)
            {
                foreach (Book b in checkedBooks)
                {
                    chkListCheckedOut.Items.Add($"{b.ISBN}, " +
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
                    cboBooksAvail.Items.Add($"{b.ISBN}, " +
                                            $"{b.Title},  " +
                                            $"{b.Author},  " +
                                            $"{b.PubDate},  " +
                                            $"{b.Category}");
                }
            }

            lstSelectedBooks.Items.Clear();
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            List<Book> memberBooks = LibraryDB.GetMemberBooks();
            
            if (memberBooks != null)
            {
                var selectedItems = chkListCheckedOut.SelectedItems;

                List<Book> selectedBooks = GetSelectedItems(
                    selectedItems);

                if (LibraryDB.CheckInBooks(selectedBooks))
                {
                    MessageBox.Show("Check-In Successful.");

                    LoadBoxes();
                }
                else
                {
                    MessageBox.Show("Nothing selected.");
                }
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
            if (lstSelectedBooks.SelectedIndex != -1)
            {
                var selectedItems = lstSelectedBooks.SelectedItems;

                List<Book> uncheckedBooks =
                    LibraryDB.GetAllUncheckedBooks();

                List<Book> selectedBooks = GetSelectedItems(
                    selectedItems);

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
                MessageBox.Show("Nothing selected.");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Converts selectedItems to string ISBNs.
        /// </summary>
        /// <param name="selectedItems"></param>
        /// <param name="books"></param>
        /// <returns>List<Book></returns>
        private List<Book> GetSelectedItems(ListBox.
            SelectedObjectCollection selectedItems)
        {
            List<string> stringISBNs = new List<string>();
            
            foreach (var item in selectedItems)
            {
                stringISBNs.Add(item.ToString().
                    Substring(0, item.ToString().IndexOf(",")));
            }

            List<Book> selectedBooks = 
                LibraryDB.GetSelectedBooks(stringISBNs);

            return selectedBooks;
        }
    }
}
