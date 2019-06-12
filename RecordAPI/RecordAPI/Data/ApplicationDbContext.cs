using Microsoft.EntityFrameworkCore;
using RecordAPI.Models.Domain_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecordAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Record> Records { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
