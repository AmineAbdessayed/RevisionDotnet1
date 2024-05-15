using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{

    public enum EtatTache
    {
        Ouverte,EnCours,Fermee
    }
    public  class Tache
    {


        public string Titre { get; set; }
        public EtatTache Etat { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public virtual Member Member{ get; set; }
        public virtual Sprint Sprint{ get; set; }

        public string MemberKey {  get; set; }
        public int SprintKey {  get; set; }


    }
}
