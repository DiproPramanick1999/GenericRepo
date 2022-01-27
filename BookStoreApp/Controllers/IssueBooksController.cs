using BookStoreApp.Models.DAL;
using BookStoreApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStoreApp.Controllers
{
    public class IssueBooksController : Controller
    {
        // GET: IssueBooks
        //private IBookStoreRepo repo = new BookStoreRepo();
        //private _IAllRepository<IssueBook> repo;
        private IUnitOfWork repo;
        public IssueBooksController()
        {
            this.repo = new UnitOfWork();
        }
        public ActionResult Index()
        { 
            return View(repo.IssueBookRepository.GetModel());
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            IssueBook issueBook = repo.IssueBookRepository.GetModelById(id);
            return View(issueBook);
        }
        [HttpPost]
        public ActionResult Update(IssueBook book)
        {
            if (!ModelState.IsValid)
            {
                return View("Update");
            }
            repo.IssueBookRepository.UpdateModel(book);
            return RedirectToAction("Index");
        }
    }
}