using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Forms;

namespace Church_Timer
{
    public class Product
    {
        private string code;
        private string description;
        private decimal price;

        public Product()
        {
        
        
        }

        public Product(string code, string description, decimal price)
        {
            this.Code = code;
            this.Description = description;
            this.Price = price;
        }

        public string Code {get; set;}
        public string Description {get; set;}
        public decimal Price { get; set; }

        public string GetDisplayText(string sep)
        {
            return code + sep + price.ToString("c") + sep + description;
        }


    }
}
