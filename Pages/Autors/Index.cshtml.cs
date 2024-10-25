using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Andra_lab2.Data;
using Pop_Andra_lab2.Models;

namespace Pop_Andra_lab2.Pages.Autors
{
    public class IndexModel : PageModel
    {
        private readonly Pop_Andra_lab2.Data.Pop_Andra_lab2Context _context;

        public IndexModel(Pop_Andra_lab2.Data.Pop_Andra_lab2Context context)
        {
            _context = context;
        }

        public IList<Autor> Autor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Autor = await _context.Autor.ToListAsync();
        }
    }
}
