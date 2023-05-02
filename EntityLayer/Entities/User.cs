using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User     
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(40)]
        public int UserName { get; set; }
        [Required]
        [StringLength(30)]
        public int UserSurname { get; set; }
        [Required]
        [StringLength(150)]
        public int UserEmail { get; set; }
        [Required]
        [StringLength(20)]
        public int UserPassword { get; set; }
    }
}
