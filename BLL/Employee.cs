using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz.BLL
{
    public class Employee
    {
        private string vEmployeeID, vFirstName, vLastName, vEmail, vUserName, vPassword, vRole;

        public string EmployeeID 
        {
            get => vEmployeeID;
            set => vEmployeeID = value; 
        }

        public string FirstName 
        {
            get => vFirstName;
            set => vFirstName = value; 
        }

        public string LastName 
        {
            get => vLastName;
            set => vLastName = value; 
        }

        public string Email 
        {
            get => vEmail;
            set => vEmail = value; 
        }

        public string UserName
        {
            get => vUserName;
            set => vUserName = value;
        }

        public string Password 
        {
            get => vPassword;
            set => vPassword = value; 
        }

        public string Role 
        {
            get => vRole;
            set => vRole = value; 
        }
        public Employee(string firstName, string lastName, string email, string username, string password, string role)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserName = username;
            Password = password; 
            Role = role;
        }
        public Employee(string employeeid, string firstName, string lastName, string email, string username, string password, string role)
        {
            EmployeeID = employeeid;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserName = username;
            Password = password;
            Role = role;
        }

        public Employee()
        {

        }
    }
}
