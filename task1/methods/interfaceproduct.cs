
using product.Models;
using Microsoft.AspNetCore.Mvc;

namespace product.methods

{
    public interface interfaceproduct
    {
        Task<List<Product>> GetAll();
        Task<Product> Getbyid(int id);
        void Add(Product product);
        void Update(Product product);
        Task<List<Product>> Delete(int id);
    }
}
