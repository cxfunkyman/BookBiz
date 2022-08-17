using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz.BLL
{
    public class Book
    {
        private string vBookId, vISBN, vTitle, vUnitPrice, vQOH, vCategory;
        private string vYearOfPublish, vAuthors, vPublisher;

        public string BookId 
        {
            get => vBookId;
            set => vBookId = value; 
        }

        public string ISBN 
        {
            get => vISBN;
            set => vISBN = value; 
        }

        public string Title 
        {
            get => vTitle;
            set => vTitle = value; 
        }

        public string UnitPrice 
        {
            get => vUnitPrice;
            set => vUnitPrice = value; 
        }

        public string YearOfPublish 
        {
            get => vYearOfPublish;
            set => vYearOfPublish = value; 
        }

        public string QOH 
        {
            get => vQOH;
            set => vQOH = value; 
        }

        public string Authors 
        {
            get => vAuthors;
            set => vAuthors = value; 
        }

        public string Category 
        {
            get => vCategory;
            set => vCategory = value; 
        }

        public string Publisher 
        {
            get => vPublisher;
            set => vPublisher = value; 
        }
    }
}
