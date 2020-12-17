using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Negreanu_Anca_Lab6.Models;

namespace Negreanu_Anca_Lab6.Data
{
    public class Negreanu_Anca_Lab6Context : DbContext
    {
        public Negreanu_Anca_Lab6Context (DbContextOptions<Negreanu_Anca_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Negreanu_Anca_Lab6.Models.Book> Book { get; set; }
    }
}
