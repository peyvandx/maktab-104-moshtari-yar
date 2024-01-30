using Data;
using Microsoft.AspNetCore.Mvc;

namespace MoshtariYarUI.Areas.Admin.Controllers
{
    [Area("Admin")]
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
