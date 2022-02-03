using System.Linq;


namespace Mandalay.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }

        void SaveProduct(Product product);
    }
}
