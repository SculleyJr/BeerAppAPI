using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.BuilderProperties;

namespace GulpAPI.Models
{
    public class Brewery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public int Established { get; set; }
        public string Size { get; set; }
    }
}