using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IAModel.Models
{
    public class Asset
    {
        public int AssetID { get; set; }
        public int AssetType { get; set; }
        public string IdentNbr { get; set; }
        public string Name  { get; set; }
        public string Description { get; set; }
        public DateTime CommissionedDt { get; set; }
        public DateTime DecommissionedDt { get; set; }
        public int DeploymentStatus { get; set; } //--deployed, awaiting deployment, being repaired, 
        public int State { get; set; }  //--active, down for maint, offline etc
        public DateTime LastMaintDt { get; set; }

    }
}