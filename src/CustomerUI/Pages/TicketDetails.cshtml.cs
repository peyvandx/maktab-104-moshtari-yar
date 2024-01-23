using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerUI.Pages
{
    public class TicketDetailsModel : PageModel
    {


        #region Model
        [BindProperty]
        public int Id { get; set; }
        #endregion


        public void OnGet(int id)
        {
            this.Id=id;

            // get ticket from database
        }
    }
}
