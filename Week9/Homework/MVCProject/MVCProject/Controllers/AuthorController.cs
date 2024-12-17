using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;

namespace MVCProject.Controllers
{
    public class AuthorController : Controller
    {
        // GET: AuthorController
        public ActionResult Index() 
        { 
            var authors = new List<AuthorViewModel>();
            Data.Authors?.ForEach(a =>
            {
                authors.Add(new AuthorViewModel
                {
                    Id = a.Id,
                    FullName = a.FullName,
                    DateOfBirth = a.DateOfBirth
                });

            });
            return View(authors);
        }

        // GET: AuthorController/Details/5
        public ActionResult Details(int id)
        {
            Author author = Data.Authors.Find(a => a.Id == id);
            if(author == null)
            {
                return NotFound("Author not found. Check the ID.");
            }

            return View(new AuthorViewModel
            {
                Id=author.Id,
                FullName=author.FullName,
                DateOfBirth=author.DateOfBirth


            });
        }

        // GET: AuthorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AuthorCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Author newauthor = new Author
                {
                    //Id = Data.Authors.Max(a => a.Id) +1,
                    Id = Data.Authors.Any() ? Data.Authors.Max(a => a.Id) + 1 : 1,

                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    DateOfBirth = model.DateOfBirth
                };
                Data.Authors.Add(newauthor);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id)
        {
            Author author = Data.Authors.FirstOrDefault(a => a.Id == id);
            if(author == null)
            {
                return NotFound("Author not found. Check the ID.");
            }
            AuthorEditViewModel authorEditViewModel = new AuthorEditViewModel()
            {
                Id=author.Id,
                FirstName=author.FirstName,
                LastName=author.LastName,
                DateOfBirth=author.DateOfBirth
                   
            }; 
            
            return View(authorEditViewModel);
        }

        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AuthorEditViewModel model)
        {
            Author author = Data.Authors.FirstOrDefault(a => a.Id == model.Id);
            if (author == null)
            {
                return NotFound("Author not found. Check the ID.");
            }

            if (ModelState.IsValid)  
            {  
                author.FirstName = model.FirstName;
                author.LastName = model.LastName;
                author.DateOfBirth = model.DateOfBirth;
                return RedirectToAction("Details", new {id = model.Id});

            }
            return View(model);
        }

        // GET: AuthorController/Delete/5
        public ActionResult Delete(int id)
        {
            Author author = Data.Authors.FirstOrDefault(b => b.Id == id);
            if (author == null)  
            {
                return NotFound("Author not found. Check the ID.");
            }

            return View(new AuthorViewModel { Id = author.Id, FullName = author.FullName });
        }

        // POST: AuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, AuthorEditViewModel model)
        {
            Author author = Data.Authors.Find(a => a.Id == model.Id);
            if (author == null)  
            {
                return NotFound("Author not found. Check the ID.");
            }
            Data.Books.RemoveAll(b => b.AuthorId == author.Id);
            Data.Authors.Remove(author);
            return RedirectToAction("Index");
        }
    }
}
