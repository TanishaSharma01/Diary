using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {


        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }


        // Four Steps to Add aTable
        // 1. Create A Model Class
        // 2. Add DB Set
        // 3. add-migration AddDiaryEntryTable
        // 4. update-database

    }
}
