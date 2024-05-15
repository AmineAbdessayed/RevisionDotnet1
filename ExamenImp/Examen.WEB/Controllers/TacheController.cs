using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.WEB.Controllers
{
    public class TacheController : Controller
    {

        readonly IService<Tache> tacheService;


        public TacheController(IService<Tache> tacheService)
        {
            this.tacheService = tacheService;
        }




        //thabet fel id type mteeo 
        public ActionResult GoToDetails(string  id)
        {
            return View(tacheService.GetAll().Where(h => h.MemberKey == id)
                                              .Select(a => a.Member).First());
        }





        //GET






        // GET: TacheController
        public ActionResult Index()
        {
            return View(tacheService.GetAll().Where(h=>h.Etat==EtatTache.Ouverte).OrderBy(h=>h.Titre).ToList());
        }

        // GET: TacheController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }



        // GET: TacheController/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST




        // POST: TacheController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Tache amine)
        {
            try
            {
                tacheService.Add(amine);
                tacheService.Commit(); 

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TacheController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TacheController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TacheController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TacheController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
