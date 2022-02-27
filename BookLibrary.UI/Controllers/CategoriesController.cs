using BookLibrary.Ent.Entities;
using BookLibrary.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.UI.Controllers
{
    public class CategoriesController : Controller
    {
        IUnitOfWork _unitOfWork;
        Categories _categories;
        public CategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult List()
        {
            var pList = _unitOfWork._catRepos.List();
            return View(pList);

        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Categories model)
        {
            _unitOfWork._catRepos.Create(model);
            _unitOfWork.Save();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Edit(Categories model)
        {
            _unitOfWork._catRepos.Update(model);
            _unitOfWork.Save();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Delete(Categories model)
        {
            _unitOfWork._catRepos.Delete(model);
            _unitOfWork.Save();
            return RedirectToAction("List");
        }
    }
}
