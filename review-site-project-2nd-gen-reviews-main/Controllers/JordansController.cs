using Microsoft.AspNetCore.Mvc;
using Review_Site_Sok_Michael.Models;
using Review_Site_Sok_Michael.Repositories;

namespace Review_Site_Sok_Michael.Controllers
{
    public class JordansController : Controller
    {
        public IRepository<JordansModel> _jordansRepo;

        public JordansController(IRepository<JordansModel> jordansRepo)
        {
            _jordansRepo = jordansRepo;
        }
        public ViewResult Index()
        {
            return View(_jordansRepo.GetAll());
        }

        public ViewResult Details(int id)
        {
            return View(_jordansRepo.GetByID(id));
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(JordansModel jordans)
        {
            if (ModelState.IsValid)
            {
                _jordansRepo.Create(jordans);
                return RedirectToAction("Index");
            }
            return View(jordans);
        }
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var shoe = _jordansRepo.GetByID(id);
            if (shoe == null)
            {
                return NotFound();
            }
            return View(shoe);
        }
        [HttpPost]
        public ActionResult Delete(int id, bool notUsed)
        {
            if (id == null)
            {
                return Problem("Entity set ShoesContext._jordansRepo is null");
            }
            var shoe = _jordansRepo.GetByID(id);
            if (shoe == null)
            {
                return NotFound();
            }
            _jordansRepo.Delete(shoe);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, JordansModel shoe)
        {
            if (id == null)
            {
                return Problem("Is Null");
            }
            if (shoe == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _jordansRepo.Edit(shoe);
                return RedirectToAction("Index");
            }
            return View(shoe);
        }
    }
}

