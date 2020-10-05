using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASM.ASP.NET.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public string GroupName { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime BirthDay { get; set; }
    }
}