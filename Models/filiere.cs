using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace STManagemenet.Models
{
    public class Filiere
    {

        public Filiere()
        {
            this.Students = new HashSet<Student>();
        }

        [Key]
        public int Id_filiere { get; set; }

        public string Nom_filiere { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
