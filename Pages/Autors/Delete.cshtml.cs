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
    public class DeleteModel : PageModel
    {
        private readonly Pop_Andra_lab2.Data.Pop_Andra_lab2Context _context;

        public DeleteModel(Pop_Andra_lab2.Data.Pop_Andra_lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Autor Autor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autor = await _context.Autor.FirstOrDefaultAsync(m => m.ID == id);

            if (autor == null)
            {
                return NotFound();
            }
            else
            {
                Autor = autor;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autor = await _context.Autor.FindAsync(id);
            if (autor != null)
            {
                Autor = autor;
                _context.Autor.Remove(Autor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
