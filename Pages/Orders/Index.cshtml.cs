using Microsoft.AspNetCore.Mvc.RazorPages;
using ASPCRUDAssignment.Data;
using ASPCRUDAssignment.Models;
using System.Collections.Generic;
using System.Linq;

namespace ASPCRUDAssignment.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Order> Orders { get; set; }

        public void OnGet()
        {
            Orders = _context.Orders.ToList();
        }
    }
}