using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GulpAPI.Models
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Abv { get; set; }
        public int Rating { get; set; }
        public Brewery Brewery { get; set; }
        public string Availability { get; set; }
    }
}