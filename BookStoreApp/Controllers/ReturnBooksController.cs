using BookStoreApp.Models.DAL;
using BookStoreApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStoreApp.Controllers
{
    public class ReturnBooksController : Controller
    {
        // GET: ReturnBooks
        //private IBookStoreRepo repo = new BookStoreRepo();
        //private _IAllRepository<ReturnBook> repo;
        private IUnitOfWork repo;
        public ReturnBooksController()
        {
            this.repo = new UnitOfWork();
        }
        public ActionResult Index()
        {
            
            return View(repo.ReturnBookRepository.GetModel());
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            ReturnBook returnBook = repo.ReturnBookRepository.GetModelById(id);
            return View(returnBook);
        }
        [HttpPost]
        public ActionResult Update(ReturnBook returnBook)
        {
            if (!ModelState.IsValid)
            {
                return View("Update");
            }
            repo.ReturnBookRepository.UpdateModel(returnBook);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            ReturnBook returnBook = repo.ReturnBookRepository.GetModelById(id);
            return View(returnBook);
        }
        [HttpPost]
        public ActionResult DeleteReturnBook(int id)
        {
            if (!ModelState.IsValid)
            {
                return View("Delete");
            }
            repo.ReturnBookRepository.DeleteModel(id);
            return RedirectToAction("Index");
        }
    }
}