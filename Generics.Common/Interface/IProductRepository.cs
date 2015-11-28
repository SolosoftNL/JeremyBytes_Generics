using System.Collections.Generic;

namespace Generics.Common.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProduct(int productId);

        void AddProduct(Product newProduct);

        void UpdateProduct(int productId, Product updatedProduct);

        void DeleteProduct(int productId);

        void UpdateProducts(IEnumerable<Product> updatedProducts);
    }
}
