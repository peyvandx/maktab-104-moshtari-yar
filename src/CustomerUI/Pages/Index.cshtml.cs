using Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerUI.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Tickets = new List<Ticket>()
            {
                new Ticket()
                {
                    Id = 1,
                    Title = "درخواست اول",
                    Description = "*********************"
                },
                new Ticket()
                {
                    Id = 2,
                    Title = "درخواست دوم",
                    Description = "++++++++++++++++++++++++"
                }
            };
        }

        #region Model
        public List<Ticket> Tickets { get; set; }
        #endregion


        public void OnGet()
        {

        }

        [HttpPost]
        public void OnPost()
        {

        }
    }
}
