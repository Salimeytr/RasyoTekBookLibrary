using BookLibrary.Ent;
using BookLibrary.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.UI.Controllers
{
    public class PublishersController : Controller
    {
        IUnitOfWork _unitOfWork;
        Publishers _publishers;
        public PublishersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult List()
        {
            var pList = _unitOfWork._pubRepos.List();
            return View(pList);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Publishers model)
        {
            _unitOfWork._pubRepos.Create(model);
            _unitOfWork.Save();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Edit(Publishers model)
        {
            _unitOfWork._pubRepos.Update(model);
            _unitOfWork.Save();
            return RedirectToAction("List");
        }


        [HttpGet]
        public IActionResult Delete()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Delete(Publishers model)
        {
            _unitOfWork._pubRepos.Delete(model);
            _unitOfWork.Save();
            return RedirectToAction("List");
        }
    }
}
