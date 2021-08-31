using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderMVC.Models
{
    public class Queue
    {
        public int Id { get; set; }
        public string DrinkName { get; set; }
        public bool Completed { get; set; }

        public Queue(string drinkName)
        {
            DrinkName = drinkName;
        }
    }
}
