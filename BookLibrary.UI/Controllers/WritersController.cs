using BookLibrary.Ent.Entities;
using BookLibrary.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.UI.Controllers
{
    public class WritersController : Controller
    {
        IUnitOfWork _unitOfWork;
        Writers _writers;
        public WritersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult List()
        {
            var pList = _unitOfWork._writerRepos.List();
            return View(pList);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Writers model)
        {
            _unitOfWork._writerRepos.Create(model);
            _unitOfWork.Save();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Edit(Writers model)
        {
            _unitOfWork._writerRepos.Update(model);
            _unitOfWork.Save();
            return RedirectToAction("List");
        }


        [HttpGet]
        public IActionResult Delete()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Delete(Writers model)
        {
            _unitOfWork._writerRepos.Delete(model);
            _unitOfWork.Save();
            return RedirectToAction("List");
        }

    }
}
