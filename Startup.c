using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntroducingTheWondersOfTheWorld
{
    public class Startup : Controller
    {
        // GET: Startup
        public ActionResult Index()
        {
            return View();
        }

        // GET: Startup/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Startup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Startup/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Startup/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Startup/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Startup/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Startup/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
