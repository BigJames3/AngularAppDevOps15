namespace AngularAppDevOps15.Server.Data
{
    public class Attendance
    {
        public int Id { get; set; } // Identifiant unique de la présence
        public int EmployeeId { get; set; } // Identifiant de l'employé
        public DateTime Date { get; set; } // Date de présence
        public bool IsPresent { get; set; } // Indicateur de présence (vrai/faux)
        public Employee Employee { get; set; } // Navigation vers l'employé
    }
}