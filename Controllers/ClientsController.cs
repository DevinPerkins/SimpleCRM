using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleCRM.Data;
using SimpleCRM.Models;

namespace SimpleCRM.Controllers
{
    // Base route for this controller:
    // /Clients
    [Route("[controller]")]
    public class ClientsController : Controller
    {
        private readonly CrmContext _context;

        public ClientsController(CrmContext context)
        {
            _context = context;
        }

        // GET /Clients
        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var clients = await _context.Clients.ToListAsync();
            return View(clients);
        }

        // GET /Clients/Create
        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        // POST /Clients/Create
        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Client client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(client);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(client);
        }
    }
}
