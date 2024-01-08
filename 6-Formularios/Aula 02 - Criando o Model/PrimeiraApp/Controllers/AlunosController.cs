using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Data;
using PrimeiraApp.Models;

namespace PrimeiraApp.Controllers
{
    public class AlunosController : Controller
    {
        private readonly AppDbContext _context;

        public AlunosController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,DataNascimento,Email,EmailConfirmacao,Avaliacao,Ativo")] Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
