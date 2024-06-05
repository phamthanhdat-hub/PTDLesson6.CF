using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PtdLesson06.CF.Models
{
    public class PtdBook
    {

        [Key]
        public int PtdId { get; set; }
        public string PtdBookId { get; set; }
        public string PtdTitle { get; set; }
        public string PtdAuthor { get; set; }
        public int PtdYear { get; set; }
        public string PtdPulisher { get; set; }
        public string PtdPicture { get; set; }
        public int PtdCategoryId { get; set; }
        //thuoc tinh quan he
        public virtual PtdCategory PtdCategory { get; set; }
    }
}