using product.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace product.methods
{

    public class Productmethods : interfaceproduct
    

    {
        public  List<Product> productList { get; set; }
        public  int nextproductid = 3;
         Productmethods()
        {
            productList = new List<Product>()
            {
                new Product() {Id=1, Name="cola",price=30},
                new Product() {Id=2, Name="juice",price=15}
            };
            
        }
        public async Task<List<Product>> GetAll()
        {
            return productList ;
        }
        public async Task<Product> Getbyid(int id)
        {
            return productList.FirstOrDefault(x => x.Id == id);
        }
        public void Add(Product p)
        {
            p.Id= nextproductid++;
            productList.Add(p);
        }
        public void  Update(Product p)
        {
            var index = productList.FindIndex(x=>x.Id==p.Id);
            if (index == -1)
                return;
            productList[index] = p;

        }
        public  async Task<List<Product>> Delete(int id)
        {
            Product p1= productList.First(x=>x.Id==id);
            productList.Remove(p1);
            return (productList);
            /*var p=Getbyid(id);
            if (p is null)
                return;
            productList.Remove(p);*/
        }

       
       
    }
}
