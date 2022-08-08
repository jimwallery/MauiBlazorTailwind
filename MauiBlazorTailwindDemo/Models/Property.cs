using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorTailwindDemo.Models
{
    public class Property
    {
        public string ImageUrl { get; set; }
        public string ImageAlt { get; set; }
        public int Beds { get; set; }
        public int Baths { get; set; }
        public string Title { get; set; }
        public int PriceInCents { get; set; }
        public string FormattedPrice { get; set; }
        public int ReviewCount { get; set; }
        public int Rating { get; set; }

    }
}
