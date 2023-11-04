﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Sizes
    {
        [Key]
        public int SizeId { get; set; }
        public string SizeName { get; set; }

        virtual public List<Product>? Products  { get; set; }
        
    }
}
