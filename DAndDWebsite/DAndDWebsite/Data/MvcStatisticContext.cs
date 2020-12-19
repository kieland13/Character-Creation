using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAndDWebsite.Models;

namespace DAndDWebsite.Data
{
    public class MvcStatisticContext : DbContext
    {
        public MvcStatisticContext (DbContextOptions<MvcStatisticContext> options)
            : base(options)
        {
        }

        public DbSet<Statistic> Statistic { get; set; }
    }
}
