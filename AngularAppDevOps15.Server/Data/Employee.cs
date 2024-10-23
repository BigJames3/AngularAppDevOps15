namespace AngularAppDevOps15.Server.Data
{
    public class Employee
    {
        public int Id { get; set; } // Identifiant unique de l'employé
        public string FirstName { get; set; } // Prénom
        public string LastName { get; set; } // Nom
        public string Email { get; set; } // Adresse e-mail
        public string PhoneNumber { get; set; } // Numéro de téléphone
        public DateTime HireDate { get; set; } // Date d'embauche
        public int DepartmentId { get; set; } // Identifiant du département
        public Department Department { get; set; } // Navigation vers le département
    }
}