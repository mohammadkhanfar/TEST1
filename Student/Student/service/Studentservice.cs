using Student.Interservice;
using Student.Models;
using Student.service;

namespace Student.service
{
    public class Studentservice : Iservicess<student>
    {
        List<student> students;
        public Studentservice()
        {
            students = new List<student>()
            { new student() { Id = 1, Name = "MOhammad", Message = "hello mohammad" },
                new student() { Id = 2, Name = "Rami", Message = "Hello Rami" }};
        }   

        public List<student> Delete(int id)
        {
            student s=students.FirstOrDefault(x=>x.Id == id);
            students.Remove(s);
            return students;    
        }

        public List<student> GetAll()
        {
            return students;
        }

        public student Getbyid(int id)
        {
            return students.FirstOrDefault(x=>x.Id==id);
            
        }

        public List<student> Insert(student item)
        {
            students.Add(item);
            return students;
        }
    }
}
