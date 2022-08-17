using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz.BLL
{
    public class User
    {
        private string vUserID, vEmployeeID, vName, vUserName, vPassword, vPosition;
        
        public string UserID 
        { 
            get => vUserID; 
            set => vUserID = value; 
        }

        public string EmployeeID
        {
            get => vEmployeeID;
            set => vEmployeeID = value;
        }

        public string Name 
        {
            get => vName;
            set => vName = value; 
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

        public string Position 
        {
            get => vPosition;
            set => vPosition = value; 
        }

        public User(string userID, string name, string userName, string password, string position)
        {
            UserID = userID;
            Name = name;
            UserName = userName;
            Password = password;
            Position = position;
        }

        public User(string name, string userName, string password, string position)
        {            
            Name = name;
            UserName = userName;
            Password = password;
            Position = position;
        }

        public User()
        {
        }
    }
}
