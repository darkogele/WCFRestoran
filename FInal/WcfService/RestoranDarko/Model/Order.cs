using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestoranDarko.Model
{
    public class Order
    {
        public int Id { get; set; }
        public Musterija Customer  { get; set; }
        public List<Food> Food { get; set; }
        public List<Drink>Drink { get;set; }
        public double Price { get; set; }
        //public string Waiter { get; set; }
        
    }
}