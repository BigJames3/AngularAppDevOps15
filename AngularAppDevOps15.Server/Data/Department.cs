namespace AngularAppDevOps15.Server.Data
{
    public class Department
    {
        public int Id { get; set; } // Identifiant unique du département
        public string Name { get; set; } // Nom du département
        public ICollection<Employee> Employees { get; set; } // Liste des employés dans ce département
    }
}