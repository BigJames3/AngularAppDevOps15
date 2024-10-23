using Microsoft.EntityFrameworkCore;

namespace AngularAppDevOps15.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructeur pour passer les options de configuration à la classe de base
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Définis ici tes DbSet pour les entités
        public DbSet<Employee> Employees { get; set; } // Table des employés
        public DbSet<Department> Departments { get; set; } // Table des départements
        public DbSet<Attendance> Attendances { get; set; } // Table des présences
        public DbSet<WorkHour> WorkHours { get; set; } // Table des heures de travail (facultatif)
    }
}
