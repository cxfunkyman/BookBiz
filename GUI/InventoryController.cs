using BookBiz.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBiz.BLL;
using BookBiz.Validation;

namespace BookBiz.GUI
{
    public partial class InventoryController : Form
    {
        DataTable dt = new DataTable();
        string anyID;

        public InventoryController()
        {
            InitializeComponent();
        }

        private void InventoryController_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login listForm = new Login(); //opens the windows form listform
            listForm.Show();
        }

        private void ClearAll()
        {
            textBoxISBN.Clear();
            textBoxTitle.Clear();
            textBoxUnitPrice.Clear();
            textBoxYearOfPublish.Clear();
            textBoxQOH.Clear();
            textBoxSearch1.Clear();
        }

        public void ClearAuthor()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
        }

        private void CBAuthors()
        {
            comboBoxAuthors.DataSource = DA_InventoryController.dtComboBox("authors_view");
            comboBoxAuthors.DisplayMember = "author_name";
            comboBoxAuthors.ValueMember = "author_name";
        }

        private void CBCategory()
        {
            comboBoxCategories.DataSource = DA_InventoryController.dtComboBox("categories_view");
            comboBoxCategories.DisplayMember = "category";
            comboBoxCategories.ValueMember = "category";
        }

        private void CBPublisher()
        {
            comboBoxPublisher.DataSource = DA_InventoryController.dtComboBox("publishers_view");
            comboBoxPublisher.DisplayMember = "publisher";
            comboBoxPublisher.ValueMember = "publisher";
        }

        private void InventoryController_Load(object sender, EventArgs e)
        {
            dataGridViewBooks.DataSource = DA_InventoryController.dtBook();
            dataGridViewAuthors.DataSource = DA_InventoryController.dtAuthor();
            dataGridViewCategories.DataSource = DA_InventoryController.dtCategory();
            dataGridViewPublishers.DataSource = DA_InventoryController.dtPublisher();
            CBAuthors();
            CBCategory();
            CBPublisher();
        }

        //This section is fot Books

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxISBN.Text) &&
                Validator.IsEmpty(textBoxTitle.Text) &&
                Validator.IsEmpty(textBoxUnitPrice.Text) &&
                Validator.IsEmpty(textBoxYearOfPublish.Text) &&
                Validator.IsEmpty(textBoxQOH.Text))
            {
                Author aut = DA_InventoryController.SearchAuthor(comboBoxAuthors.Text);
                Category cat = DA_InventoryController.SearchCategory(comboBoxCategories.Text);
                Publisher pub = DA_InventoryController.SearchPublisher(comboBoxPublisher.Text);

                Book book = new Book();

                book.ISBN = textBoxISBN.Text;
                book.Title = textBoxTitle.Text;
                book.UnitPrice = textBoxUnitPrice.Text;
                book.YearOfPublish = textBoxYearOfPublish.Text;
                book.QOH = textBoxQOH.Text;
                book.Authors = aut.AuthorID;
                book.Category = cat.CatId;
                book.Publisher = pub.PubId;

                DA_InventoryController.SaveBook(book);
                dataGridViewBooks.DataSource = DA_InventoryController.dtBook();
                MessageBox.Show("Book has been added");
                ClearAll();
            }

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxISBN.Text) &&
                Validator.IsEmpty(textBoxTitle.Text) &&
                Validator.IsEmpty(textBoxUnitPrice.Text) &&
                Validator.IsEmpty(textBoxYearOfPublish.Text) &&
                Validator.IsEmpty(textBoxQOH.Text))
            {
                Author aut = DA_InventoryController.SearchAuthor(comboBoxAuthors.Text);
                Category cat = DA_InventoryController.SearchCategory(comboBoxCategories.Text);
                Publisher pub = DA_InventoryController.SearchPublisher(comboBoxPublisher.Text);

                Book book = new Book();

                book.BookId = anyID;
                book.ISBN = textBoxISBN.Text;
                book.Title = textBoxTitle.Text;
                book.UnitPrice = textBoxUnitPrice.Text;
                book.YearOfPublish = textBoxYearOfPublish.Text;
                book.QOH = textBoxQOH.Text;
                book.Authors = aut.AuthorID;
                book.Category = cat.CatId;
                book.Publisher = pub.PubId;

                DA_InventoryController.ModifyBook(book);
                dataGridViewBooks.DataSource = DA_InventoryController.dtBook();
                MessageBox.Show("Book has been updated");
                ClearAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxISBN.Text) &&
                Validator.IsEmpty(textBoxTitle.Text) &&
                Validator.IsEmpty(textBoxUnitPrice.Text) &&
                Validator.IsEmpty(textBoxYearOfPublish.Text) &&
                Validator.IsEmpty(textBoxQOH.Text))
            {
                Book book = new Book();

                book.BookId = anyID;

                DA_InventoryController.DeleteBook(book);
                dataGridViewBooks.DataSource = DA_InventoryController.dtBook();
                MessageBox.Show("Book has been deleted");
                ClearAll();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(Validator.IsEmpty(comboBoxSearchBy.Text) && Validator.IsEmpty(textBoxSearch1.Text))
            {
                Book book = DA_InventoryController.SearchBook(textBoxSearch1.Text, comboBoxSearchBy.Text);

                anyID = book.BookId;
                textBoxISBN.Text = book.ISBN;
                textBoxTitle.Text = book.Title;
                textBoxUnitPrice.Text = book.UnitPrice;
                textBoxYearOfPublish.Text = book.YearOfPublish;
                textBoxQOH.Text = book.QOH;
                comboBoxAuthors.SelectedIndex = Convert.ToInt32(book.Authors) - 1;
                comboBoxCategories.SelectedIndex = Convert.ToInt32(book.Category) - 1;
                comboBoxPublisher.SelectedIndex = Convert.ToInt32(book.Publisher) - 1;

            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridViewBooks.DataSource = DA_InventoryController.dtBook();
        }

        private void btnLogout1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This section is for Authors

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if(Validator.IsEmpty(textBoxFirstName.Text) && 
                Validator.IsEmpty(textBoxLastName.Text) &&
                Validator.IsEmpty(textBoxEmail.Text))
            {
                Author aut = new Author();

                aut.FirstName = textBoxFirstName.Text;
                aut.LastName = textBoxLastName.Text;
                aut.Email = textBoxEmail.Text;

                DA_InventoryController.SaveAuthor(aut);
                dataGridViewAuthors.DataSource = DA_InventoryController.dtAuthor();
                MessageBox.Show("Author has been added");
                ClearAuthor();
                CBAuthors();
                CBCategory();
                CBPublisher();
            }
        }

        private void btnModify2_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxFirstName.Text) &&
                Validator.IsEmpty(textBoxLastName.Text) &&
                Validator.IsEmpty(textBoxEmail.Text))
            {
               // Author aut = DA_InventoryController.SearchAuthor(textBoxSearch2.Text, comboBoxAuthors.Text);

                Author author = new Author();

                author.AuthorID = anyID;
                author.FirstName = textBoxFirstName.Text;
                author.LastName = textBoxLastName.Text;
                author.Email = textBoxEmail.Text;

                DA_InventoryController.ModifyAuthor(author);
                dataGridViewAuthors.DataSource = DA_InventoryController.dtAuthor();
                MessageBox.Show("Author has been updated");
                ClearAuthor();
                CBAuthors();
                CBCategory();
                CBPublisher();
            }
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxFirstName.Text) &&
                Validator.IsEmpty(textBoxLastName.Text) &&
                Validator.IsEmpty(textBoxEmail.Text))
            {
                Author aut = new Author();
                aut.AuthorID = anyID;

                DA_InventoryController.DeleteAuthor(aut);
                dataGridViewAuthors.DataSource = DA_InventoryController.dtAuthor();
                MessageBox.Show("Author has been deleted");
                ClearAuthor();
                CBAuthors();
                CBCategory();
                CBPublisher();
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            if(Validator.IsEmpty(textBoxSearch2.Text) &&
                Validator.IsEmpty(comboBoxSearchBy2.Text))
            {
                Author aut = DA_InventoryController.SearchAuthor(textBoxSearch2.Text, comboBoxSearchBy2.Text);

                anyID = aut.AuthorID;
                textBoxFirstName.Text = aut.FirstName;
                textBoxLastName.Text = aut.LastName;
                textBoxEmail.Text = aut.Email;
            }
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            dataGridViewAuthors.DataSource = DA_InventoryController.dtAuthor();
        }
        
        //This section is for Category

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxCatName.Text))
            {
                Category cat = new Category();

                cat.CategoryName = textBoxCatName.Text;

                DA_InventoryController.SaveCategory(cat);
                dataGridViewCategories.DataSource = DA_InventoryController.dtCategory();
                MessageBox.Show("Category has been added");
                textBoxCatName.Clear();
                CBAuthors();
                CBCategory();
                CBPublisher();
            }
        }

        private void btnModify3_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxCatName.Text))
            {
              // Category cat = DA_InventoryController.SearchCategory(textBoxSearch3.Text);

                Category cat = new Category();

                cat.CatId = anyID;
                cat.CategoryName = textBoxCatName.Text;

                DA_InventoryController.ModifyCategory(cat);
                dataGridViewCategories.DataSource = DA_InventoryController.dtCategory();
                MessageBox.Show("Category has been updated");
                textBoxSearch3.Clear();
                textBoxCatName.Clear();
                CBAuthors();
                CBCategory();
                CBPublisher();
            }
        }

        private void btnDelete3_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxCatName.Text))
            {
                //Category cat = DA_InventoryController.SearchCategory(textBoxSearch3.Text);

                Category cat = new Category();
                cat.CatId = anyID;

                DA_InventoryController.DeleteCategory(cat);
                dataGridViewCategories.DataSource = DA_InventoryController.dtCategory();
                MessageBox.Show("Category has been deleted");
                textBoxSearch3.Clear();
                textBoxCatName.Clear();
                CBAuthors();
                CBCategory();
                CBPublisher();
            }
        }

        private void btnSearch3_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxSearch3.Text))
            {
                Category cat = DA_InventoryController.SearchCategory(textBoxSearch3.Text);

                anyID = cat.CatId;
                textBoxCatName.Text = cat.CategoryName;
            }
        }

        private void btnList3_Click(object sender, EventArgs e)
        {
            dataGridViewCategories.DataSource = DA_InventoryController.dtCategory();
        }

        //This section is for Publishers

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxPubName.Text))
            {
                Publisher pub = new Publisher();

                pub.PublisherName = textBoxPubName.Text;

                DA_InventoryController.SavePublisher(pub);
                dataGridViewPublishers.DataSource = DA_InventoryController.dtPublisher();
                MessageBox.Show("Publisher has been added");
                textBoxPubName.Clear();
                CBAuthors();
                CBCategory();
                CBPublisher();
            }
        }

        private void btnModify4_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxPubName.Text))
            {
               // Publisher pub = DA_InventoryController.SearchPublisher(textBoxSearch4.Text);

                Publisher pub = new Publisher();

                pub.PubId = anyID;
                pub.PublisherName = textBoxPubName.Text;

                DA_InventoryController.ModifyPublisher(pub);
                dataGridViewPublishers.DataSource = DA_InventoryController.dtPublisher();
                MessageBox.Show("Publisher has been updated");
                textBoxSearch4.Clear();
                textBoxPubName.Clear();
                CBAuthors();
                CBCategory();
                CBPublisher();
            }
        }

        private void btnDelete4_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxPubName.Text))
            {
                //Category cat = DA_InventoryController.SearchCategory(textBoxSearch3.Text);

                Publisher pub = new Publisher();
                pub.PubId = anyID;

                DA_InventoryController.DeletePublisher(pub);
                dataGridViewPublishers.DataSource = DA_InventoryController.dtPublisher();
                MessageBox.Show("Publisher has been deleted");
                textBoxSearch4.Clear();
                textBoxPubName.Clear();
                CBAuthors();
                CBCategory();
                CBPublisher();
            }
        }

        private void btnSearch4_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxSearch3.Text))
            {
                Publisher pub = DA_InventoryController.SearchPublisher(textBoxSearch4.Text);

                anyID = pub.PubId;
                textBoxPubName.Text = pub.PublisherName;
            }
        }

        private void btnList4_Click(object sender, EventArgs e)
        {
            dataGridViewPublishers.DataSource = DA_InventoryController.dtPublisher();
        }
    }
}
