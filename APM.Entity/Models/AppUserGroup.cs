using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APM.Entity.Models
{
    [Table("AppUserGroups")]
    public class AppUserGroup
    {
        [StringLength(128)]
        [Key]
        [Column(Order = 1)]
        public string UserName { set; get; }

        [Key]
        [Column(Order = 2)]
        public int GroupID { set; get; }

        [ForeignKey("UserName")]
        public virtual AppUser User { set; get; }

        [ForeignKey("GroupID")]
        public virtual AppGroup AppGroup { set; get; }
    }
}
