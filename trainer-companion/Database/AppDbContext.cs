using Microsoft.EntityFrameworkCore;
using System.IO;

namespace trainer_companion.Database
{
    internal class AppDbContext : DbContext
    {
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string appdatapath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appdataDirectory = Path.Combine(appdatapath, "trainer-companion");
            Directory.CreateDirectory(appdataDirectory); // Ensure the directory exists
            optionsBuilder.UseSqlite($"Data Source={appdataDirectory}\\trainer-companion.db");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Note>()
        //        .Property(n => n.NoteContent)
        //        .HasMaxLength(1000);
        //}
    }
}

