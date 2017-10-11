﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage ="The field {0} is required.")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length")]
        [Index("Category_Description_Index", IsUnique = true)]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
