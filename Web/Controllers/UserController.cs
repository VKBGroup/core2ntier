using AppCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: NoteView
        public ActionResult Index()
        {
            return View(_userService.GetAll());
        }

        // GET: NoteView/Details/5
        public ActionResult Details(int id)
        {
            return View(_userService.Get(id));
        }

        // GET: NoteView/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NoteView/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NoteView/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NoteView/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NoteView/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NoteView/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}