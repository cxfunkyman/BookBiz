using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz.BLL
{
    public class Author
    {
        private string vAuthorID, vFirstName, vLastName, vEmail, vFullName;
        
        public string AuthorID 
        {
            get => vAuthorID;
            set => vAuthorID = value; 
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

        public string FullName
        {
            get => vFullName;
            set => vFullName = value;
        }
    }
}
