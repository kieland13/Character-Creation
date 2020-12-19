using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAndDWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace DAndDWebsite.Data
{
    public class MvcWeaponContext : DbContext
    {
        public MvcWeaponContext (DbContextOptions<MvcWeaponContext> options)
            : base(options)
        {
        }
        public DbSet<Weapon> Weapon { get; set; }
    }
}
