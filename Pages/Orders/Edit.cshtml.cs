using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ASPCRUDAssignment.Data;
using ASPCRUDAssignment.Models;

namespace ASPCRUDAssignment.Pages.Orders
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Order Order { get; set; }

        public void OnGet(int id)
        {
            Order = _context.Orders.Find(id);
        }

        public IActionResult OnPost()
        {
            _context.Orders.Update(Order);

            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}