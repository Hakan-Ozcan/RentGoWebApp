using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User     
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(40)]
        public string UserName { get; set; }
        [Required]
        [StringLength(30)]
        public string UserSurname { get; set; }
        [Required]
        [StringLength(150)]
        public string UserEmail { get; set; }
        [Required]
        [StringLength(20)]
        public string UserPassword { get; set; }
    }
}
