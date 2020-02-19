using Microsoft.EntityFrameworkCore;
using Parcial1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Inscripcion> Inscripcion { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source= Database/InscripcionDB");
        }
    }
}
