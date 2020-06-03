using STManagemenet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STManagemenet.Services
{
    public interface IStudentService
    {
        void Save(Student student);
        IEnumerable<Student> FindAll();
        Student GetStudent(int id);
        void DeleteStudent(int id);

        void Save(Filiere filiere);
        IEnumerable<Filiere> FindAllFiliere();
        Filiere GetFiliere(int id);
    }
}
