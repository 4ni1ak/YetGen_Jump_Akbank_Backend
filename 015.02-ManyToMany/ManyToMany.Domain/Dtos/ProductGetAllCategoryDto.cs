﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany.Domain.Dtos
{
     public class ProductGetAllCategoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
