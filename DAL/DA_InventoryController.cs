using BookBiz.BLL;
using BookBiz.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBiz.DAL
{
    public static class DA_InventoryController
    {
        static string query;
        static string tableName;
        static DataTable dt = new DataTable();

        public static DataTable dtBook()
        {
            tableName = "book_view";
            query = "SELECT * FROM " + tableName + ";";

            dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null)
                return dt;

            else
                return null;
        }

        public static DataTable dtAuthor()
        {
            tableName = "author_view";
            query = "SELECT * FROM " + tableName + ";";

            dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null)
                return dt;

            else
                return null;
        }

        public static DataTable dtCategory()
        {
            tableName = "category_view";
            query = "SELECT * FROM " + tableName + ";";

            dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null)
                return dt;

            else
                return null;
        }

        public static DataTable dtPublisher()
        {
            tableName = "publisher_view";
            query = "SELECT * FROM " + tableName + ";";

            dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null)
                return dt;

            else
                return null;
        }

        public static DataTable dtComboBox(string text)
        {
            query = "SELECT * FROM " + text + ";";

            dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null)
                return dt;

            else
                return null;
        }

        //public static void SaveBook(Book book, string author, string category, string publisher)
        public static void SaveBook(Book book)
        {
  /*          query = "SELECT AID FROM author_view WHERE \"Name\" LIKE '" + author + "%' COLLATE NOCASE";
            dt = DB_ConnectQueries.Query_Connect_DB(query);
            book.Authors = dt.Rows[0].ItemArray[0].ToString();

            query = "SELECT CID FROM category_view WHERE \"Category\" LIKE '" + category + "%' COLLATE NOCASE";
            dt = DB_ConnectQueries.Query_Connect_DB(query);
            book.Category = dt.Rows[0].ItemArray[0].ToString();

            query = "SELECT PID FROM publisher_view WHERE \"Publisher\" LIKE '" + publisher + "%' COLLATE NOCASE";
            dt = DB_ConnectQueries.Query_Connect_DB(query);
            book.Publisher = dt.Rows[0].ItemArray[0].ToString();*/

            query = "INSERT INTO book(ISBN, title, unit_price, year_of_publish, QOH, author_Id, category_Id, publisher_Id) VALUES('" + book.ISBN + "', '" + book.Title + "', '" + book.UnitPrice + "', '" + book.YearOfPublish + "', '" + book.QOH + "', '" + book.Authors + "', '" + book.Category + "', '" + book.Publisher + "')";
            DB_ConnectQueries.Save_Connect_DB(query);

            query = "SELECT BID FROM book_view WHERE \"Title\" LIKE '" + book.Title + "%' COLLATE NOCASE";
            dt = DB_ConnectQueries.Query_Connect_DB(query);
            book.BookId = dt.Rows[0].ItemArray[0].ToString();

            query = "INSERT INTO book_author(book_Id, author_Id) VALUES('" + book.BookId + "', '" + book.Authors + "')";
            DB_ConnectQueries.Save_Connect_DB(query);

            query = "INSERT INTO book_category(book_Id, category_Id) VALUES('" + book.BookId + "', '" + book.Category + "')";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static void SaveAuthor(Author aut)
        {
            query = "INSERT INTO author(first_name, Last_name, email) VALUES('" + aut.FirstName + "', '" + aut.LastName + "', '" + aut.Email + "')";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static void SaveCategory(Category cat)
        {
            query = "INSERT INTO category(category_name) VALUES('" + cat.CategoryName + "')";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static void SavePublisher(Publisher pub)
        {
            query = "INSERT INTO publisher(publisher_name) VALUES('" + pub.PublisherName + "')";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static Book SearchBook(string text, string index)
        {
            Book book = new Book();

            query = "SELECT * FROM book WHERE " + index + " LIKE '" + text + "%' COLLATE NOCASE";
            dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null && dt.Rows.Count != 0)
            {
                book.BookId = dt.Rows[0].ItemArray[0].ToString();
                book.ISBN = dt.Rows[0].ItemArray[1].ToString();
                book.Title = dt.Rows[0].ItemArray[2].ToString();
                book.UnitPrice = dt.Rows[0].ItemArray[3].ToString();
                book.YearOfPublish = dt.Rows[0].ItemArray[4].ToString();
                book.QOH = dt.Rows[0].ItemArray[5].ToString();
                book.Authors = dt.Rows[0].ItemArray[6].ToString();
                book.Category = dt.Rows[0].ItemArray[7].ToString();
                book.Publisher = dt.Rows[0].ItemArray[8].ToString();

            }

            return book;
        }

        public static Author SearchAuthor(string text)
        {
            Author aut = new Author();

            query = "SELECT * FROM author_view WHERE \"Name\" LIKE '" + text + "%' COLLATE NOCASE";
            dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null && dt.Rows.Count != 0)
            {
                aut.AuthorID = dt.Rows[0].ItemArray[0].ToString();
                aut.FullName = dt.Rows[0].ItemArray[1].ToString();
                aut.Email = dt.Rows[0].ItemArray[2].ToString();
            }

            return aut;
        }

        public static Author SearchAuthor(string text, string index)
        {
            Author aut = new Author();

            query = "SELECT * FROM authors_view_comp WHERE \"" + index + "\" LIKE '" + text + "%' COLLATE NOCASE";
            dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null && dt.Rows.Count != 0)
            {
                aut.AuthorID = dt.Rows[0].ItemArray[0].ToString();
                aut.FirstName = dt.Rows[0].ItemArray[1].ToString();
                aut.LastName = dt.Rows[0].ItemArray[2].ToString();
                aut.Email= dt.Rows[0].ItemArray[3].ToString();
            }

            return aut;
        }

        public static Category SearchCategory(string text)
        {
            Category cat = new Category();

            query = "SELECT * FROM category_view WHERE \"Category\" LIKE '" + text + "%' COLLATE NOCASE";
            dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null && dt.Rows.Count != 0)
            {
                cat.CatId = dt.Rows[0].ItemArray[0].ToString();
                cat.CategoryName = dt.Rows[0].ItemArray[1].ToString();
            }

            return cat;
        }

        public static Publisher SearchPublisher(string text)
        {
            Publisher pub = new Publisher();

            query = "SELECT * FROM publisher_view WHERE \"Publisher\" LIKE '" + text + "%' COLLATE NOCASE";
            dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null && dt.Rows.Count != 0)
            {
                pub.PubId = dt.Rows[0].ItemArray[0].ToString();
                pub.PublisherName = dt.Rows[0].ItemArray[1].ToString();
            }

            return pub;
        }

        public static void ModifyBook(Book book)
        {
            query = "UPDATE book SET ISBN = '" + book.ISBN + "', title = '" + book.Title + "', unit_price = '" + book.UnitPrice + "', year_of_publish = '" + book.YearOfPublish + "', QOH = '" + book.QOH + "', author_Id = '" + book.Authors + "', category_Id = '" + book.Category + "', publisher_Id = '" + book.Publisher + "' WHERE book_id = '" + book.BookId + "'";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static void ModifyAuthor(Author aut)
        {
            query = "UPDATE author SET first_name = '" + aut.FirstName + "', last_name = '" + aut.LastName + "', email = '" + aut.Email + "' WHERE author_id = '" + aut.AuthorID + "'";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static void ModifyCategory(Category cat)
        {
            query = "UPDATE category SET category_name = '" + cat.CategoryName + "' WHERE category_id = '" + cat.CatId + "'";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static void ModifyPublisher(Publisher pub)
        {
            query = "UPDATE publisher SET publisher_name = '" + pub.PublisherName + "' WHERE publisher_id = '" + pub.PubId + "'";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static void DeleteBook(Book book)
        {
            query = "DELETE FROM book WHERE book_Id = '" + book.BookId + "'";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static void DeleteAuthor(Author aut)
        {
            query = "DELETE FROM author WHERE author_Id = '" + aut.AuthorID +"'";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static void DeleteCategory(Category cat)
        {
            query = "DELETE FROM category WHERE category_Id = '" + cat.CatId +"'";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static void DeletePublisher(Publisher pub)
        {
            query = "DELETE FROM publisher WHERE publisher_Id = '" + pub.PubId +"'";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

    }
}
