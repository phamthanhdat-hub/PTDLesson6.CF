using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PtdLesson06.CF.Models
{
    public class PtdCategory
    {
        [Key]
        public int PtdId { get; set; }
        public string PtdCategoryName { get; set; }
        // thuoc tinh quan he
        public virtual ICollection<PtdBook> PtdBooks { get; set; }
    }
}