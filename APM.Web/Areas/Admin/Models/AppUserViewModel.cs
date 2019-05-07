using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class UserViewModel
    {
        [Required]
        public string UserName { set; get; }

        [MaxLength(50)]
        public string PassWord { set; get; }

        [MaxLength(256)]
        public string FullName { set; get; }

        [MaxLength(256)]
        public string Email { set; get; }

        [MaxLength(20)]
        public string PhoneNumber { set; get; }

        public bool? Sex { set; get; }

        [MaxLength(256)]
        public string Address { set; get; }

        public DateTime? BirthDay { set; get; }
    }
}