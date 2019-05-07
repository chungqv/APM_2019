using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class AppGroupViewModel
    {
        [Required]
        public int ID { set; get; }

        [MaxLength(50)]
        public string Description { set; get; }
    }
}