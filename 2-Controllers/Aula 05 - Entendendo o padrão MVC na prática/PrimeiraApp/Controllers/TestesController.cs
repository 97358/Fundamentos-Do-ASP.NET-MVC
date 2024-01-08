using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrimeiraApp.Controllers
{
    public class TestesController : Controller
    {
        // GET: Testes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Testes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TestesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestesController/Create
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

        // GET: TestesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TestesController/Edit/5
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

        // GET: TestesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TestesController/Delete/5
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
