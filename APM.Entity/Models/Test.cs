using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM.Entity.Models
{
    [Table("Tests")]
    public class Test
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity )]
        public int ID { set; get; }
        [MaxLength(50)]
        public string Message { set; get; }
    }
}
