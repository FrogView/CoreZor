using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Core.Razor.Data;
using Core.Razor.Models;

namespace Core.Razor.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Core.Razor.Data.CoreRaZorContext _context;

        public IndexModel(Core.Razor.Data.CoreRaZorContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
