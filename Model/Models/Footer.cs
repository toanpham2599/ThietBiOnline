using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
