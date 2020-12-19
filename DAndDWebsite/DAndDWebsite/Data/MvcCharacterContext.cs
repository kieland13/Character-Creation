using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAndDWebsite.Models;

namespace DAndDWebsite.Data
{
    public class MvcCharacterContext : DbContext
    {
        public MvcCharacterContext (DbContextOptions<MvcCharacterContext> options)
            : base(options)
        {
        }
        public DbSet<Character> Character { get; set; }
    }
}
