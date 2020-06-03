using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace STManagemenet.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        
        public string Cne { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        [ForeignKey("Filiere")]
        public Nullable<int> Id_filiere { get; set; }
        public virtual Filiere Filiere { get; set; }
    }
}
