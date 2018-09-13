using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupSourceControlProject.Forms
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            LoadBoxes();
        }

        /// <summary>
        /// Clears form and loads list boxes with data.
        /// </summary>
        private void LoadBoxes()
        {
            Clear();
            
            List<Member> allMembers =
                MemberDB.GetAllMembers();

            if (allMembers != null)
            {
                foreach (Member m in allMembers)
                {
                    lstMembers.Items.Add($"{m.MemberID}, " +
                                         $"{m.Username},  " +
                                         $"{m.LastName},  " +
                                         $"{m.FirstName},  " +
                                         $"Admin: " +
                                         $"{m.IsAdmin}");
                }
            }

            List<Book> allBooks =
                LibraryDB.GetAllBooks();

            if (allBooks != null)
            {
                foreach (Book b in allBooks)
                {
                    lstBooks.Items.Add($"{b.ISBN}, " +
                                       $"{b.Title},  " +
                                       $"{b.Author},  " +
                                       $"{b.PubDate},  " +
                                       $"{b.Category}");
                }
            }
        }

        private void AddMember(object sender, EventArgs e)
        {
            Member member = new Member();

            if (MemberSubmission())
            {
                member.MemberID = MemberDB.CreateMemberID();
                
                member.Username = txtUsername3.Text;

                member.FirstName = txtFirstName2.Text;
                
                member.LastName = txtLastName2.Text;

                member.PIN = Convert.ToInt32(txtPIN3.Text);

                if (chkAdmin3.Checked is true)
                    member.IsAdmin = true;

                if (MemberDB.IsMember(member))
                {
                    MessageBox.Show("Already a member. Try again.");
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
                                "Fields empty or incorrectly filled.");
            }

            LoadBoxes();
        }

        private void RemoveMember(object sender, EventArgs e)
        {
            if (lstMembers.SelectedIndex != -1)
            {
                object selectedItem = lstMembers.SelectedItem;

                string memberId = GetSelectedItemId(selectedItem);

                MemberDB.RemoveMember(memberId);

                LoadBoxes();
            }
        }

        private void AddBook(object sender, EventArgs e)
        {
            Book book = new Book();

            if (BookSubmission())
            {
                book.ISBN = txtISBN.Text;
                
                book.Title = txtTitle.Text;

                book.Author = txtAuthor.Text;

                book.PubDate = Convert.ToInt32(txtPubDate.Text);

                book.Category = txtCategory.Text;

                if (LibraryDB.IsBook(book))
                {
                    MessageBox.Show("There is already a book in the " +
                                    "database with this title. Try again.");
                }
                else
                {
                    LibraryDB.AddBook(book);
                }
            }
            else
            {
                MessageBox.Show("Incorrect submission. " +
                                "Fields empty or incorrectly filled.");
            }

            LoadBoxes();
        }

        private void RemoveBook(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex != -1)
            {
                object selectedItem = lstBooks.SelectedItem;

                string isbn = GetSelectedItemId(selectedItem);

                LibraryDB.RemoveBook(isbn);

                LoadBoxes();
            }
        }

        private static bool IsInt(string input)
        {
            if (!String.IsNullOrEmpty(input))
            {
                return Int32.TryParse(input, out int test);
            }
            return false;
        }

        private static bool IsRange(string isbn)
        {
            int intIsbn = Convert.ToInt32(isbn);

            if (intIsbn < 10000000 || 
                intIsbn > 99999999)
                return false;
            else
                return true;
        }

        private static bool IsEmpty(string input)
        {
            return String.IsNullOrWhiteSpace(input);
        }

        private bool MemberSubmission()
        {
            if (IsEmpty(txtUsername3.Text))
                return false;

            if (IsEmpty(txtFirstName2.Text))
                return false;

            if (IsEmpty(txtLastName2.Text))
                return false;

            if (!IsInt(txtPIN3.Text))
                return false;

            return true;
        }

        private bool BookSubmission()
        {
            // check if isbn is an int
            if (IsInt(txtISBN.Text) is false)
            {
                MessageBox.Show("ISBN must be an 8 digit number.");
                return false;
            }
            
            // check if isbn is correct length
            if (IsRange(txtISBN.Text) is false)
            {
                MessageBox.Show("ISBN must be an 8 digit number.");
                return false;
            }

            // check if isbn is already in db
            if (LibraryDB.IsBook(txtISBN.Text))
            {
                MessageBox.Show("Duplicate ISBN. Try again.");
                return false;
            }

            if (IsEmpty(txtTitle.Text))
                return false;

            if (IsEmpty(txtAuthor.Text))
                return false;

            if (IsEmpty(txtCategory.Text))
                return false;

            return true;
        }

        private void Clear()
        {
            lstMembers.Items.Clear();
            txtUsername3.Clear();
            txtFirstName2.Clear();
            txtLastName2.Clear();
            txtPIN3.Clear();
            chkAdmin3.Checked = false;
            lstBooks.Items.Clear();
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPubDate.Clear();
            txtCategory.Clear();
        }

        /// <summary>
        /// Converts selected item to string.
        /// </summary>
        /// <param name="selectedItems"></param>
        /// <param name="books"></param>
        /// <returns>int intId</returns>
        private string GetSelectedItemId(object selectedItem)
        {
            string id = selectedItem.ToString().
                    Substring(0, selectedItem.ToString().IndexOf(","));

            return id;
        }
    }
}
