using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppAss15.Models
{
    [Table("Team")]

    public class Team
    {
        [Key]
        public int TId { get; set; }
        public string TName { get; set; }
        public string TEmail { get; set; }
        public string TSlogan { get; set; }
    }
}