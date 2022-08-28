using product.methods;
using product.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Route("[controller]")]

    public class ProductController : ControllerBase
    {
        public interfaceproduct intp;
        public ProductController(interfaceproduct interpro)
        {
            intp= interpro; 
        }
        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {
            return Ok( intp.GetAll());
        }
        [HttpGet("{id}")]
        public ActionResult<Task<Product>> Getbyid(int id)
            
        {
            var x = 100000;
            var pro=intp.Getbyid(id);
            if(pro==null)
                return NotFound();
            return pro;
        }
        [HttpPost]
        public ActionResult Add(Product p)
        {
            intp.Add(p);
            return CreatedAtAction(nameof(Add), new {id=p.Id},p);
        }[HttpPut("{id}")]
        public ActionResult Update (int id,Product p)
        {
            if(id!=p.Id)
                return BadRequest();
            var pro = intp.Getbyid(id);
            intp.Update(p);
            return NoContent();
        }
        [HttpDelete("{id}")]
       public async Task <ActionResult<List<Product>>> Delete(int id)
        {
            return Ok(intp.Delete(id));
            
        }
    }
}
