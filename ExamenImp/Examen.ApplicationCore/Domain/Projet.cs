using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Projet
    {

        [Key]
        public string Code { get; set; }

        [Required(ErrorMessage ="this field is required")]
        public string Titre { get; set; }
        public string Description { get; set; }


        public virtual IList<Sprint> Sprints { get; set; }


    }
}
