using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint_17112020
{
    class CampusContext : DbContext
    {
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // I add a connection to a database instance while the context configures
            optionsBuilder.UseSqlServer(
                @"Server=LOCALHOST\SQLEXPRESS;Database=CampusEFC;Integrated Security=True");
        }
    }
}
