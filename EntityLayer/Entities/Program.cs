using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Program
    {
        [Key]
        public int ID { get; set; }

        public string ProgramName { get; set; }

   
    }
}
