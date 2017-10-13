namespace Products.Domain
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        public int CategoryID { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length")]
        [Index("Product_Description_Index", IsUnique = true)]
        public string Description { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        public string Image { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        public DateTime LastPurchase { get; set; }

        [Display(Name = "Stock")]
        public double Stock { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [JsonIgnore]
        public virtual Category Category { get; set; }
    }
}
