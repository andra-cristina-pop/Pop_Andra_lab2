using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pop_Andra_lab2.Models;

namespace Pop_Andra_lab2.Data
{
    public class Pop_Andra_lab2Context : DbContext
    {
        public Pop_Andra_lab2Context (DbContextOptions<Pop_Andra_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Pop_Andra_lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Pop_Andra_lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Pop_Andra_lab2.Models.Autor> Autor { get; set; } = default!;

    }
}
