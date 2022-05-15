using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RedatorSaude.Models;

namespace RedatorSaude.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RedatorSaude.Models.Document> Document { get; set; }
        public DbSet<RedatorSaude.Models.UsuarioSistema> UsuarioSistema { get; set; }
        
    }
}
