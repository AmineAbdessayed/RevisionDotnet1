using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    internal interface IServiceTache:IService<Tache>
    {


        int NbTachesEnCours(string matricule);

        int nbJours(DateTime dateDebut, DateTime dateFin);

        IList<Tache> TachesParPRojet();
    }
}
