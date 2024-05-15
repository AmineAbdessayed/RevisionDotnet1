using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Sprint
    {

        public int Id { get; set; }

        [MaxLength(150)]
        public string Description { get; set; }
        public DateTime DateDebut { get; set; }

        public virtual Projet MyProjet { get; set; }

        public virtual IList<Tache> Taches { get; set; }  

    }
}
