using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBiz.DB;

namespace BookBiz.DAL
{
    public static class DA_Login
    {
        static string query;
        static string tableName;
        static DataTable dt = new DataTable();

        public static bool Login(string name, string password)
        {
            tableName = "users_view";
            query = "SELECT \"User Name\", \"Password\" FROM " + tableName + " WHERE \"User Name\" LIKE '" + name + "%' COLLATE NOCASE;";

            dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null && dt.Rows[0].ItemArray[0].ToString().Equals(name) && dt.Rows[0].ItemArray[1].ToString().Equals(password))
                    return true;
            
            else 
                return false;
        }
        public static string UserRole(string name)
        {
            query = "SELECT Position FROM " + tableName + " WHERE \"User Name\" LIKE '" + name + "%' COLLATE NOCASE;";

            dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null)
                return dt.Rows[0].ItemArray[0].ToString();

            else
                return null;
        }
    }
}
