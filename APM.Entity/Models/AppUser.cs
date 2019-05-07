using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;

namespace APM.Entity.Models
{
    [Table("AppUsers")]
    public class AppUser
    {
        [Key]
        [MaxLength(128)]
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

        public virtual IEnumerable<Order> Orders { set; get; }
    }
}