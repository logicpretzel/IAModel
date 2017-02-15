using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IAModel.Models
{
    public class Client
    {

        public int ClientID { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone1 { get; set; }
        public int Phone1Type { get; set; }
        public string Phone2 { get; set; }
        public int Phone2Type { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime EffDate { get; set; }




    }
}