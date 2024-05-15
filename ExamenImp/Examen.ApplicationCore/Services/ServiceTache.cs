using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    internal class ServiceTache : Service<Tache>, IServiceTache
    {







        public ServiceTache(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public int nbJours(DateTime dateDebut, DateTime dateFin)
        {

            int a = GetAll().Where(h => h.DateFin >DateTime.Now).Count();

            return (int)(GetAll().Where(h => h.Etat == EtatTache.Fermee).ToList().Sum(h=>(h.DateFin-h.DateDebut).TotalDays)/a);
        }

        public int NbTachesEnCours(string matricule)
        {

            return GetAll().Where(h => h.DateFin < DateTime.Now && h.Member.Matricule == matricule).Count();

        }

        public IList<Tache> TachesParPRojet()
        {

            return (IList<Tache>)GetAll().GroupBy(h => h.Sprint.MyProjet.Titre).ToList();
        }
    }
}
