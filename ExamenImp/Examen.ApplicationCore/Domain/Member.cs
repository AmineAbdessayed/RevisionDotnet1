using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public  class Member
    {

        [Key]
        public string Matricule { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public virtual IList<Tache> Taches { get; set; }
    }
}
