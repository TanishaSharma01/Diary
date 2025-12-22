using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DiaryApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {


        }
        // Four Steps to Add aTable
        // 1. Create A Model Class
        // 2. Add DB Set
        // 3. add-migration AddDiaryEntryTable
        // 4. update-database

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        //override this method to seed data to our database

        //Tools -> Nuget Manager Console -> add-migration AddedSeedingDataDiaryEntry (basically update)
        //update-database (to actually update the database)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // HasData and HasKey to remember
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry 
                { 
                    Id = 1, Title = "Went hiking", Content = "Went hiking with Joe!", Created = DateTime.Now 
                },
                new DiaryEntry { 
                    Id = 2, Title = "Made Tea", Content = "Made Tea with Angela!", Created = DateTime.Now 
                },
                new DiaryEntry { 
                    Id = 3, Title = "Went diving", Content = "Went diving with Christie!", Created = DateTime.Now 
                }
                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings =>
                warnings.Ignore(RelationalEventId.PendingModelChangesWarning)
            );
        }




    }
}
