using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz.BLL
{
    public class Category
    {
        private string vCatId, vCategoryName;

        public string CatId 
        {
            get => vCatId;
            set => vCatId = value; 
        }

        public string CategoryName 
        {
            get => vCategoryName;
            set => vCategoryName = value; 
        }
    }
}
