using Microsoft.EntityFrameworkCore;
using STManagemenet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STManagemenet.Services
{
    public class StudentServiceImpl : IStudentService
    {
        StudentContext context;

        public StudentServiceImpl(StudentContext context)
        {
            this.context = context;
        }

        public void DeleteStudent(int id)
        {
            var st = context.Students.Find(id);
            context.Students.Remove(st);
            context.SaveChanges();
        }

        public IEnumerable<Student> FindAll()
        {
            return context.Students.Include(x=>x.Filiere).ToList();
        }

        public IEnumerable<Filiere> FindAllFiliere()
        {
            return context.Filieres.ToList();
        }

        public Filiere GetFiliere(int id)
        {
            return context.Filieres.Find(id);
        }

        public Student GetStudent(int id)
        {
            return context.Students.Include(x => x.Filiere).FirstOrDefault(x => x.Id == id);
        }

        public void Save(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }

        public void Save(Filiere filiere)
        {
            context.Filieres.Add(filiere);
            context.SaveChanges();
        }
    }
}
