using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz.BLL
{
    public class Roles
    {
        private string vId, vRoleName;

        public string Id 
        {
            get => vId;
            set => vId = value; 
        }
        public string RoleName 
        {
            get => vRoleName;
            set => vRoleName = value; 
        }
    }
}
