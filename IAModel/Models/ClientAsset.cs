using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IAModel.Models
{
    public class ClientAsset
    {
        public int ClientID { get; set; }
        public int AssetID { get; set; }
        public DateTime EffDt { get; set; }
        public DateTime EndDt { get; set; }
        public int Status  { get; set; }
        public string LastLocation { get; set; }

    }
}