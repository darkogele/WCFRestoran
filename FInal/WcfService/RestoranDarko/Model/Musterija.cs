using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestoranDarko.Model
{
    public class Musterija
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Order { get; set; }
        //public DateTime OrderTime { get; set; }
        //public string FavoriteFood { get; set; }
        //public byte Photo { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
    }
}