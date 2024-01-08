using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrimeiraApp.Controllers
{
    [Route("/", Order = 0)]
    [Route("minha-conta", Order = 1)]
    [Route("gestao-da-conta", Order = 2)]
    public class TestesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet("detalhes/{id:int}")]
        public ActionResult Details(int id)
        {
            return View();
        }


        [HttpGet("novo")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestesController/Create
        [HttpPost("novo")]
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

        [HttpGet("editar/{id:int}")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TestesController/Edit/5
        [HttpPost("editar/{id:int}")]
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

        [HttpGet("excluir/{id:int}")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TestesController/Delete/5
        [HttpPost("excluir/{id:int}")]
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
