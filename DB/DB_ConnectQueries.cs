using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace BookBiz.DB
{
    public static class DB_ConnectQueries
    {
        static readonly SQLiteConnection conn = new SQLiteConnection(@"Data Source=.\DB\bookbiz.db");
        
        public static DataTable Query_Connect_DB(String query)
        {
            try
            {
                conn.Open();

                SQLiteCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);

                conn.Close();

                return dt;
            }
            catch (SQLiteException e)
            {
                MessageBox.Show("Can't connect to Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static void Save_Connect_DB(String query)
        {
            try
            {
                conn.Open();

                SQLiteCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (SQLiteException e)
            {
                MessageBox.Show("Can't connect to Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
