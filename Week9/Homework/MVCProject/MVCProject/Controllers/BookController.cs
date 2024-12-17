using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCProject.Models;

namespace MVCProject.Controllers
{
    public class BookController : Controller
    {
        // GET: BookController
        public ActionResult Index()
        {
            List<BookViewModel> models = new();
            Data.Books?.ForEach(book =>
            {
                string authorName = Data.Authors.Find(a => a.Id == book.AuthorId).FullName;
                models.Add(new BookViewModel()
                {
                    Id = book.Id,
                    AuthorFullName = authorName,
                    CopiesAvailable = book.CopiesAvailable,
                    Genre = book.Genre,
                    Title = book.Title,
                    ISBN = book.ISBN,
                    PublishDate = book.PublishDate,
                    
                });
            });

            return View(models);
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            Book book = Data.Books.Find(a => a.Id == id);
            if(book == null)
            {
                return NotFound("Book not found. Check the ID.");

            }

            return View(new BookViewModel
            {
                Id= book.Id,
                AuthorFullName = Data.Authors.Find(a => a.Id == book.AuthorId).FullName,
                CopiesAvailable = book.CopiesAvailable,
                Genre = book.Genre,
                Title = book.Title,
                ISBN = book.ISBN,
                PublishDate = book.PublishDate
            });
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            var authors = Data.Authors ?? new List<Author>();
            ViewBag.Authors = new SelectList(authors, "Id", "FullName");
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Book newbook = new Book()
                {
                    //Id = Data.Books.Max(a => a.Id), 
                    Id = Data.Books.Any() ? Data.Books.Max(a => a.Id) + 1 : 1,
                    Title = model.Title,
                    AuthorId = model.AuthorId,
                    Genre = model.Genre,
                    ISBN= model.ISBN,
                    PublishDate = model.PublishDate,
                    CopiesAvailable= model.CopiesAvailable

                };
                Data.Books.Add(newbook);
                return RedirectToAction("Index");
            } 
            var authors = Data.Authors ?? new List<Author> ();
            ViewBag.Authors = new SelectList(authors, "Id", "FullName");
            return View();
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            var book = Data.Books.FirstOrDefault(a => a.Id == id);
            if (book == null)
            {
                return NotFound("Book not found. Check the ID.");
            }
            BookEditViewModel model = new BookEditViewModel()
            {
                Id= book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Genre = book.Genre,
                ISBN= book.ISBN,
                PublishDate = book.PublishDate,   
                CopiesAvailable= book.CopiesAvailable
            };
            var authors = Data.Authors ?? new List<Author>();
            ViewBag.Authors = new SelectList(authors, "Id", "FullName");
            return View(model);
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BookEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Book book = Data.Books.FirstOrDefault(b => b.Id == model.Id);
                book.Title = model.Title;
                book.AuthorId = model.AuthorId;
                book.Genre = model.Genre;
                book.ISBN = model.ISBN;
                book.PublishDate = model.PublishDate;
                book.CopiesAvailable = model.CopiesAvailable;
                return RedirectToAction("Details", new
                {
                    id = book.Id,

                });
    
            }
            var authors = Data.Authors ?? new List<Author>();
            ViewBag.Authors = new SelectList(authors, "Id", "FullName");
            return View(model);
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            Book book = Data.Books.Find(b => b.Id == id);
            if (book == null)
            {
                return NotFound("Book not found. Check the ID.");
            }
            BookViewModel model = new BookViewModel()
            {
                Id = book.Id,
                Title = book.Title
                    
            };
            return View(model);
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, BookViewModel model)
        {
            Book book = Data.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)  
            {
               return NotFound("Book not found. Check the ID.");
            }
            Data.Books.Remove(book);
            return RedirectToAction("Index");
        }
    }
}
