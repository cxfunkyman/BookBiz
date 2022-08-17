using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz.BLL
{
    public class Orders
    {
        private string vOrderID, vOrderNumber, vBookID, vClientID, vQTY;

        public string OrderID
        {
            get => vOrderID;
            set => vOrderID = value;
        }

        public string OrderNumber
        {
            get => vOrderNumber;
            set => vOrderNumber = value;
        }

        public string BookID
        {
            get => vBookID;
            set => vBookID = value;
        }

        public string ClientID
        {
            get => vClientID;
            set => vClientID = value;
        }

        public string QTY
        {
            get => vQTY;
            set => vQTY = value;
        }
    }
}
