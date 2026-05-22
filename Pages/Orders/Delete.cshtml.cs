using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ASPCRUDAssignment.Data;
using ASPCRUDAssignment.Models;

namespace ASPCRUDAssignment.Pages.Orders
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
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
            var order = _context.Orders.Find(Order.Id);

            _context.Orders.Remove(order);

            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}