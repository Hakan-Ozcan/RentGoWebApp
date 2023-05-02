﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Authority
    {
        [Key]
        public int ID { get; set; }
        public int AuthorityGroupID { get; set; }
        public int ProgramID { get; set; }
    }
}
