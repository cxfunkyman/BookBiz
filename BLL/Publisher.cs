using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz.BLL
{
    public class Publisher
    {
        private string vPubId, vPublisherName;

        public string PubId 
        {
            get => vPubId;
            set => vPubId = value; 
        }

        public string PublisherName 
        {
            get => vPublisherName;
            set => vPublisherName = value; 
        }
    }
}
