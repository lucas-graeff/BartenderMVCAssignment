using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderMVC.Models
{
    public class Cocktail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Cocktail(string name, double price)
        {

            Name = name;
            Price = price;
        }
    }
    
}
