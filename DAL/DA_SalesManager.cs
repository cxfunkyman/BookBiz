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

    public static class DA_SalesManager
    {
        static string query;
        static string tableName;
        static DataTable dt = new DataTable();

        public static DataTable dtSales()
        {
            tableName = "client_view";
            query = "SELECT * FROM " + tableName + ";";

            dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null)
                return dt;

            else
                return null;
        }

        public static void SaveClient(Clients cli)
        {
            query = "INSERT INTO client(name, street, city, postal_code, phone_number, fax_number, credit_limit) VALUES('" + cli.Name + "', '" + cli.Street + "', '" + cli.City + "', '" + cli.PostalCode + "', '" + cli.PhoneNumber + "', '" + cli.FaxNumber + "', '" + cli.CreditLimit + "')";
            DB_ConnectQueries.Save_Connect_DB(query);
        }        

        public static void ModifyClient(Clients cli)
        {
            query = "UPDATE client SET name = '" + cli.Name + "', street = '" + cli.Street + "', city = '" + cli.City + "', postal_code = '" + cli.PostalCode + "', phone_number = '" + cli.PhoneNumber + "', fax_number = '" + cli.FaxNumber + "', credit_limit = '" + cli.CreditLimit + "' WHERE client_id = '" + cli.ClientId + "'";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static void DeleteClient(Clients cli)
        {
            query = "DELETE FROM client WHERE client_id = '" + cli.ClientId + "'";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static Clients SearchClient(string input)
        {
            Clients cli = new Clients();

            query = "SELECT * FROM client WHERE name LIKE '" + input + "%' COLLATE NOCASE";
            DataTable dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null && dt.Rows.Count != 0)
            {
                cli.ClientId = dt.Rows[0].ItemArray[0].ToString();
                cli.Name = dt.Rows[0].ItemArray[1].ToString();
                cli.Street = dt.Rows[0].ItemArray[2].ToString();
                cli.City = dt.Rows[0].ItemArray[3].ToString();
                cli.PostalCode = dt.Rows[0].ItemArray[4].ToString();
                cli.PhoneNumber = dt.Rows[0].ItemArray[5].ToString();
                cli.FaxNumber = dt.Rows[0].ItemArray[6].ToString();
                cli.CreditLimit = dt.Rows[0].ItemArray[7].ToString();
            }

            return cli;

        }
    }
}
