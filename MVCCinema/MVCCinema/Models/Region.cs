using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCinema.Models
{
    [Table("Region")]
    public class Region
    {
     
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
    }
}