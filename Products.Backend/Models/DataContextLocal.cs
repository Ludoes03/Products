namespace Products.Backend.Models
{
    using Domain;
    public class DataContextLocal: DataContext
    {
        public System.Data.Entity.DbSet<Products.Domain.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<Products.Domain.Product> Products { get; set; }
    }
}