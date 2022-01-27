using BookStoreApp.Models.DAL;
using BookStoreApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStoreApp.Controllers
{
    public class BooksCatalogController : Controller
    {
        // GET: BooksCatalog
        //private IBookStoreRepo repo = new BookStoreRepo();
        //private _IAllRepository<Book> repo;
        private UnitOfWork repo;
        public BooksCatalogController()
        {
            this.repo = new UnitOfWork();
        }
        public ActionResult Index(string searchTerm=null)
        {
            IEnumerable<Book> book = null;
            if (searchTerm != null)
            {
                book = repo.BookRepository.GetModel().Where(a => a.BookName.Contains(searchTerm) || a.Author.Contains(searchTerm)).ToList();
            }
            else{
                book = repo.BookRepository.GetModel();
            }
            return View(book);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Book());
        }
        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(new Book());
            }
            repo.BookRepository.AddModel(book);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Book book = repo.BookRepository.GetModelById(id);
            return View(book);
        }
        [HttpPost]
        public ActionResult Update(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View("Update");
            }
            repo.BookRepository.UpdateModel(book);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Book book = repo.BookRepository.GetModelById(id);
            return View(book);
        }
        [HttpPost]
        public ActionResult DeletePost(int id)
        {
            if (!ModelState.IsValid)
            {
                return View("Delete");
            }
            repo.BookRepository.DeleteModel(id);
            return RedirectToAction("Index");
        }
    }
}