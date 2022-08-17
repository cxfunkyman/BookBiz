using BookBiz.BLL;
using BookBiz.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz.DAL
{
    public static class DA_OrderClerks
    {
        static string query;
        static string tableName;
        static DataTable dt = new DataTable();

        public static DataTable dtComboBox(string text)
        {
            query = "SELECT * FROM " + text + ";";

            dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null)
                return dt;

            else
                return null;
        }

        public static DataTable dtOrderClerk()
        {
            tableName = "orders_view";
            query = "SELECT * FROM " + tableName + ";";

            dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null)
                return dt;

            else
                return null;
        }

        public static void SaveOrders(Orders ord)
        {
            query = "SELECT CID FROM client_view WHERE \"Name\" LIKE '" + ord.ClientID + "%' COLLATE NOCASE";
            dt = DB_ConnectQueries.Query_Connect_DB(query);
            ord.ClientID = dt.Rows[0].ItemArray[0].ToString();

            query = "SELECT BID FROM book_view WHERE \"Title\" LIKE '" + ord.BookID + "%' COLLATE NOCASE";
            dt = DB_ConnectQueries.Query_Connect_DB(query);
            ord.BookID = dt.Rows[0].ItemArray[0].ToString();

            query = "INSERT INTO orders(order_number, book_Id, client_Id, QTY) VALUES('" + ord.OrderNumber + "', '" + ord.BookID + "', '" + ord.ClientID + "', '" + ord.QTY + "')";
            DB_ConnectQueries.Save_Connect_DB(query);

            query = "SELECT OID FROM orders_view WHERE \"PO Number\" LIKE '" + ord.OrderNumber + "%' COLLATE NOCASE";
            dt = DB_ConnectQueries.Query_Connect_DB(query);
            ord.OrderID = dt.Rows[0].ItemArray[0].ToString();

            query = "INSERT INTO order_client(order_Id, client_Id) VALUES('" + ord.OrderID + "', '" + ord.ClientID + "')";
            DB_ConnectQueries.Save_Connect_DB(query);

            query = "INSERT INTO order_book(order_Id, book_Id) VALUES('" + ord.OrderID + "', '" + ord.BookID + "')";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static void DeleteOrders(string text)
        {
            string PONumber = SearchPONumber(text);

            query = "DELETE FROM orders WHERE order_number = '" + PONumber + "'";
            DB_ConnectQueries.Save_Connect_DB(query);

            query = "DELETE FROM order_book WHERE order_number = '" + PONumber + "'";
            DB_ConnectQueries.Save_Connect_DB(query);

            query = "DELETE FROM order_client WHERE order_number = '" + PONumber + "'";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static DataTable SearchOrders(string text)
        {    
            query = "SELECT * FROM orders_view WHERE \"PO Number\" LIKE '" + text + "%' COLLATE NOCASE";
            dt = DB_ConnectQueries.Query_Connect_DB(query);

            return dt;
        }

        public static string SearchBookID(string text)
        {       
            query = "SELECT BID FROM book_view WHERE \"Title\" LIKE '" + text + "%' COLLATE NOCASE";
            dt = DB_ConnectQueries.Query_Connect_DB(query);

            return dt.Rows[0].ItemArray[0].ToString(); 
        }

        public static string SearchClientID(string text)
        {
            query = "SELECT CID FROM client_view WHERE \"Name\" LIKE '" + text + "%' COLLATE NOCASE";
            dt = DB_ConnectQueries.Query_Connect_DB(query);  

            return dt.Rows[0].ItemArray[0].ToString();
        }

        public static string SearchOrderID(string text)
        {
            query = "SELECT OID FROM orders_view WHERE \"PO Number\" LIKE '" + text + "%' COLLATE NOCASE";
            dt = DB_ConnectQueries.Query_Connect_DB(query);

            return dt.Rows[0].ItemArray[0].ToString();
        }

        public static string SearchPONumber(string text)
        {
            query = "SELECT \"PO Number\" FROM orders_view WHERE \"PO Number\" LIKE '" + text + "%' COLLATE NOCASE";
            dt = DB_ConnectQueries.Query_Connect_DB(query);

            return dt.Rows[0].ItemArray[0].ToString();
        }

        public static string NextOrderNumber()
        {
            bool flag = true;
            string orderNumb = "";

            while (flag)
            {
                orderNumb = DA_GenerateOrders.OrderNumber();

                if(!DA_GenerateOrders.SameOrder(orderNumb))
                    flag = false;
            }

            return orderNumb;
        }

    }
}
