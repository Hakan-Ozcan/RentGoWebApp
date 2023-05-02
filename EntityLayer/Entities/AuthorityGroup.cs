﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class AuthorityGroup
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int AuthorityName { get; set; } 
    }
}
