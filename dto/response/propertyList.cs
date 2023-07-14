using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propertyListing.Entities
{
    public class propertyList
    {
        public string title { get; set; }
        public string address { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public int coveredarea { get; set; }
        public string propertytype { get; set; }
        public string isCommercial { get; set; }
        public int price { get; set; }
        
    }
}