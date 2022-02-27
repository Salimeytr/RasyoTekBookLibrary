using BookLibrary.Ent.Entities;
using BookLibrary.UI.Models;
using BookLibrary.UI.Models.ViewModel;
using BookLibrary.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.UI.Controllers
{
    public class BooksController : Controller
    {
        IUnitOfWork _uow;
        BooksModel _model;
       public BooksController(IUnitOfWork uow,BooksModel model)
        {
            _uow = uow;
            _model = model;
        }

        public IActionResult List()
        {
            var plist = _uow._bookRepos.List();
            return View(plist);
        }

        [HttpGet]

        public IActionResult Create()
        {
            _model.categoriesSelects = _uow._catRepos.GetCategoriesSelects();
            _model.publishersSelects = _uow._pubRepos.GetPublishersSelect();
            _model.writersSelects=_uow._writerRepos.GetWritersSelects();
            return View(_model);

        }

        [HttpPost]
        public IActionResult Create (BooksModel model)

        {
            _uow._bookRepos.Create(model.Books);
            _uow.Save();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            _model.categoriesSelects = _uow._catRepos.GetCategoriesSelects();
            _model.publishersSelects = _uow._pubRepos.GetPublishersSelect();
            _model.writersSelects = _uow._writerRepos.GetWritersSelects();
            _model.Books = _uow._bookRepos.Find(id);
            return View(_model);
        }
        [HttpPost]
        public IActionResult Edit(BooksModel model)
        {
            _uow._bookRepos.Update(model.Books);
            _uow.Save();
            return RedirectToAction("List");

      
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _model.categoriesSelects = _uow._catRepos.GetCategoriesSelects();
            _model.publishersSelects = _uow._pubRepos.GetPublishersSelect();
            _model.writersSelects = _uow._writerRepos.GetWritersSelects();
            _model.Books = _uow._bookRepos.Find(id);
            return View(_model);
        }
        [HttpPost]
        public IActionResult Delete(BooksModel model)
        {
            _uow._bookRepos.Delete(model.Books);
            _uow.Save();
            return RedirectToAction("List");


        }




    }
}
