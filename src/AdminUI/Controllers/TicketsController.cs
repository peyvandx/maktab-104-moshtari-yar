using Data;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace AdminUI.Controllers
{
    public class TicketsController : Controller
    {
        public IActionResult List()
        {
            var database = new InMemoryDatabase();
            var model = database.GetTickets();
            return View(model);
        }
    }
}
