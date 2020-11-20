using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VoterService.Models;

namespace VoterService.Data
{
    public class VoterDbContext : DbContext
    {
        public VoterDbContext(DbContextOptions<VoterDbContext> options) : base(options)
        {

        }

        public DbSet<Vote> Votes { get; set; }
    }
}