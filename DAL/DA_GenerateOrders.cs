using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBiz.DB;

namespace BookBiz.DAL
{
    public static class DA_GenerateOrders
    {
        public static string OrderNumber()
        {
            Random rd = new Random();
           
            int randValue;
            string rand_num = "";
            char letter;
            for (int i = 0; i < 3; i++)
            {                
                randValue = rd.Next(65, 90);

                letter = Convert.ToChar(randValue);

                rand_num = rand_num + letter;
            }
            for (int i = 0; i < 7; i++)
            {
                rand_num = rand_num + rd.Next(0, 9).ToString();
            }

            return rand_num;
        }
        public static bool SameOrder(string text)
        {
            string query = "SELECT \"PO Number\" FROM orders_view WHERE \"PO Number\" LIKE '" + text + "%' COLLATE NOCASE";
            DataTable dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt == null)
                return true;
            else
                return false;
        }
    }
}
