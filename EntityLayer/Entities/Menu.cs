using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EntityLayer.Entities
{
    public class Menu
    {
        [Key]
        public int ID { get; set; }
        [StringLength(100)]
        public string MenuName { get; set; }
        [StringLength(200)]
        public string MenuLink { get; set; }


    }
}
