using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using CodeTest.Models;
using CodeTest.DataLayer;
using Microsoft.EntityFrameworkCore;


namespace CodeTest.DataLayer
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options)
        {

        }

        // Models - DBTables
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set;}

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>()
                          .HasOne(sa => sa.Address)
                          .WithMany(c => c.Student)
                          .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Student>()
                          .HasOne(c => c.Courses)
                          .WithMany(s => s.Students)
                          .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Student>()
            //             .HasOne(sa => sa.Address )
            //             .WithMany(s => s.Student)
            //             .HasForeignKey(p => p.StudentID)
            //             .OnDelete(DeleteBehavior.Cascade);

        }




    }
}
