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
    public static class DA_MISManager
    {
        static string query;
        static string tableName;
        static DataTable dt = new DataTable();

        public static DataTable dtEmployee()
        {
            tableName = "employee_view";
            query = "SELECT * FROM " + tableName + ";";

            dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null)
                return dt;

            else
                return null;
        }

        public static DataTable dtUsers()
        {
            tableName = "users_view";
            query = "SELECT * FROM " + tableName + ";";

            dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null)
                return dt;

            else
                return null;
        }

        public static void SaveUser(User user)
        {
            query = "SELECT EID FROM employee_view WHERE \"User Name\" LIKE '" + user.UserName + "%' COLLATE NOCASE";
            DataTable dt = DB_ConnectQueries.Query_Connect_DB(query);
            user.EmployeeID = dt.Rows[0].ItemArray[0].ToString();
            if(user.EmployeeID == null || user.EmployeeID == "")            
                MessageBox.Show("Not found");
            else
            {
                query = "INSERT INTO users(employee_Id) VALUES('" + user.EmployeeID + "')";
                DB_ConnectQueries.Save_Connect_DB(query);
            }

        }

        public static string RoleNumber(string text)
        {
            query = "SELECT role_id FROM role WHERE role_name LIKE '" + text + "%';";
            DataTable dt = DB_ConnectQueries.Query_Connect_DB(query);
            
            return dt.Rows[0].ItemArray[0].ToString();
        }

        public static string EmpIdNumber(int index, string text)
        {
            DataTable dt = new DataTable();

            switch (index)
            {
                case 0:
                    query = "SELECT employee_id FROM employee WHERE first_name LIKE '" + text + "%';";
                    dt = DB_ConnectQueries.Query_Connect_DB(query);
                    return dt.Rows[0].ItemArray[0].ToString();                    

                case 1:
                    query = "SELECT employee_id FROM employee WHERE last_name LIKE '" + text + "%';";
                    dt = DB_ConnectQueries.Query_Connect_DB(query);
                    return dt.Rows[0].ItemArray[0].ToString();                    

                case 2:
                    query = "SELECT employee_id FROM employee WHERE user_name LIKE '" + text + "%';";
                    dt = DB_ConnectQueries.Query_Connect_DB(query);
                    return dt.Rows[0].ItemArray[0].ToString();                    

                default:
                    return null;

            }
        }

        public static void SaveEmployee(Employee emp)
        {
                query = "INSERT INTO employee(first_name, Last_name, email, user_name, \"password\", role_Id) VALUES('" + emp.FirstName + "', '" + emp.LastName + "', '" + emp.Email + "', '" + emp.UserName + "', '" + emp.Password + "', '" + emp.Role + "')";
                DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static User SearchEmployee(string text)
        {
            User emp = new User();

            query = "SELECT EID, Name, \"User Name\", \"Password\", Position FROM employee_view WHERE name LIKE '" + text + "%' COLLATE NOCASE";
            DataTable dt = DB_ConnectQueries.Query_Connect_DB(query);

            if(dt != null && dt.Rows.Count != 0)
            {
                emp.EmployeeID = dt.Rows[0].ItemArray[0].ToString();
                emp.Name = dt.Rows[0].ItemArray[1].ToString();
                emp.UserName = dt.Rows[0].ItemArray[2].ToString();
                emp.Password = dt.Rows[0].ItemArray[3].ToString();
                emp.Position = dt.Rows[0].ItemArray[4].ToString();
            }

            return emp;
        }

        public static Employee SearchEmployeeID(string text)
        {
            Employee emp = new Employee();

            query = "SELECT EID FROM employee_view WHERE \"User Name\" LIKE '" + text + "%' COLLATE NOCASE";
            DataTable dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null && dt.Rows.Count != 0)
            {
                emp.EmployeeID = dt.Rows[0].ItemArray[0].ToString();
            }

            return emp;
        }

        public static Employee SearchEmployee(string input, int index)
        {
            string col = "";
            Employee emp = new Employee();

            if (index == 0)
                col = "first_name";

            else if (index == 1)
                col = "last_name";

            else if (index == 2)
                col = "user_name";

            query = "SELECT * FROM employee WHERE " + col + " LIKE '" + input + "%' COLLATE NOCASE";
            DataTable dt = DB_ConnectQueries.Query_Connect_DB(query);

            if (dt != null && dt.Rows.Count != 0)
            {
                emp.EmployeeID = dt.Rows[0].ItemArray[0].ToString();
                emp.FirstName = dt.Rows[0].ItemArray[1].ToString();
                emp.LastName = dt.Rows[0].ItemArray[2].ToString();
                emp.Email = dt.Rows[0].ItemArray[3].ToString();
                emp.UserName = dt.Rows[0].ItemArray[4].ToString();
                emp.Password= dt.Rows[0].ItemArray[5].ToString();
                emp.Role = dt.Rows[0].ItemArray[6].ToString();
            }

            return emp;

        }

        public static void ModifyUser(User user)
        {
            query = "UPDATE employee SET user_name = '" + user.UserName + "', password = '" + user.Password + "' WHERE employee_id = '" + user.EmployeeID + "'";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static void ModifyEmployee(Employee emp, string text)
        {
            query = "UPDATE employee SET first_name = '" + emp.FirstName + "', last_name = '" + emp.LastName + "', email = '" + emp.Email + "', user_name = '" + emp.UserName + "', role_id = '" + emp.Role + "' WHERE employee_id = '" + text + "'";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static void DeleteUser(User user)
        {
            query = "DELETE FROM users WHERE employee_id = '" + user.EmployeeID + "'";
            DB_ConnectQueries.Save_Connect_DB(query);
        }

        public static void DeleteEmployee(string text)
        {
            query = "DELETE FROM employee WHERE employee_id = '" + text + "'";
            DB_ConnectQueries.Save_Connect_DB(query);
        }
    }
}
