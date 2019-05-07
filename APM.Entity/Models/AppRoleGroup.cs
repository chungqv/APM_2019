using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APM.Entity.Models
{
    [Table("AppRoleGroups")]
    public class AppRoleGroup
    {
        [Key]
        [Column(Order = 1)]
        public int GroupID { set; get; }

        [Column(Order = 2)]
        [Key]
        public int RoleID { set; get; }

        [ForeignKey("RoleID")]
        public virtual AppRole AppRole { set; get; }

        [ForeignKey("GroupID")]
        public virtual AppGroup AppGroup { set; get; }
    }
}
