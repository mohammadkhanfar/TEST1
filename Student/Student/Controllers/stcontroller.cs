using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student.Interservice;
using Student.Models;
using Student.service;

namespace Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class stcontroller : ControllerBase
    {
        public Iservicess<student> _stservice;
        public stcontroller(Iservicess<student> s)
        {
            _stservice = s;
        }


        [HttpGet]
        public List<student> GetAll()
        {
            return _stservice.GetAll();
        }
        [HttpGet("{id}")]
        public student Getbyid(int id)
        {
            return _stservice.Getbyid(id);
        }
        [HttpPost]
        public List<student> Insert( student item)
        {
            return _stservice.Insert(item);
        }
        [HttpDelete("{id}")]
        public List<student> Delete(int id)
        {
            return _stservice.Delete(id);
        }



    }
}
