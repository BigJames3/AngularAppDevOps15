namespace AngularAppDevOps15.Server.Data
{
    public class WorkHour
    {
        public int Id { get; set; } // Identifiant unique des heures de travail
        public int EmployeeId { get; set; } // Identifiant de l'employé
        public DateTime Date { get; set; } // Date de travail
        public TimeSpan StartTime { get; set; } // Heure de début
        public TimeSpan EndTime { get; set; } // Heure de fin
        public Employee Employee { get; set; } // Navigation vers l'employé
    }
}