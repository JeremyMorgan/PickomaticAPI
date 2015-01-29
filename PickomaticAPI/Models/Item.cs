using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PickomaticAPI.Models
{
    public class Item
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ItemID { get; set; }
        public int FeatureFK { get; set; }
        public string ItemHeadline { get; set; }
        public string ItemExcerpt { get; set; }

    
        public int FeatureId { get; set; }
        // Navigation property
        public virtual Feature Feature { get; set; }
        
        public object ItemId { get; set; }
    }
}