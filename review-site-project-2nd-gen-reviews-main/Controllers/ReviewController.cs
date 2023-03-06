using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Review_Site_Sok_Michael.Models;
using Review_Site_Sok_Michael.Repositories;

namespace Review_Site_Sok_Michael.Controllers
{
    public class ReviewController : Controller
    {
        public IRepository<ReviewModel> _reviewRepo;

        public ReviewController(IRepository<ReviewModel> reviewRepo)
        {
            _reviewRepo = reviewRepo;
        }

        public ViewResult Index()
        {
            return View(_reviewRepo.GetAll());
        }

        public ViewResult Details(int id)
        {
            return View(_reviewRepo.GetByID(id));
        }


        public ActionResult Create()
        {
            var review = new ReviewModel();
            review.JordansList = ReviewList();
            return View(review);
        }


        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(ReviewModel review)
        {
            if (ModelState.IsValid)
            {
                _reviewRepo.Create(review);
                return RedirectToAction("Index");
            }
            return View(review);
        }

        public ActionResult Edit(int id)
        {
            var review = _reviewRepo.GetByID(id);
            review.JordansList = ReviewList();
            return View(review);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ReviewModel shoe)
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
                _reviewRepo.Edit(shoe);
                return RedirectToAction("Index");
            }
            return View(shoe);
        }

        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var shoe = _reviewRepo.GetByID(id);
            if (shoe == null)
            {
                return NotFound();
            }
            return View(shoe);
        }


        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Delete(int id, bool notUsed)
        {
            if (id == null)
            {
                return Problem("Entity set ShoesContext._jordansRepo is null");
            }
            var shoe = _reviewRepo.GetByID(id);
            if (shoe == null)
            {
                return NotFound();
            }
            _reviewRepo.Delete(shoe);
            return RedirectToAction("Index");
        }
        private List<SelectListItem> ReviewList()
        {
            var list = _reviewRepo.JordansList();
            List<SelectListItem> retValue = list.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            return retValue;
        }
    }
}
