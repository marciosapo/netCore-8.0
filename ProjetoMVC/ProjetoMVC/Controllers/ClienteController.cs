using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Data;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ApplicationDBContext _db;
        public ClienteController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index(string nome)
        {
            List<Cliente> clientes;

            if (string.IsNullOrWhiteSpace(nome))
            {
                clientes = _db.clientes.ToList();
            }
            else
            {
                clientes = _db.clientes
                              .Where(p => p.nome.Contains(nome))
                              .ToList();
            }

            ViewBag.Nome = nome;
            return View(clientes);
        }
    }
}
