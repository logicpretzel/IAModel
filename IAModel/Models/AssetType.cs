using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IAModel.Models
{
    public class AssetType
    {   [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Key]
        public int ID { get; set; }

    }
}