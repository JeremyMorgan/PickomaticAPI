using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PickomaticAPI.Models
{
    public class Feature
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int FeatureID { get; set; }
        public string FeatureTitle { get; set; }
        public string FeatureDesc { get; set; }
        public string FeatureOGImage { get; set; }
        public string FeatureSiteImage { get; set; }
        public string FeatureSlug { get; set; }
        
        public object FeatureId { get; set; }
    }
}