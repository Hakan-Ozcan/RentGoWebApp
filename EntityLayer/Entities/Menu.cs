using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Menu
    {
        [Key]
        public int ID { get; set; }

        public int ProgramID { get; set; }
      
        public int? SubMenuID { get; set; }
       

    }
}
