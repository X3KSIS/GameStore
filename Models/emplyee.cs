using System.ComponentModel.DataAnnotations;
    public class Employee
    {
        public int Id {get; set; }

        [Required]
        [StringLength(100)]
        public string Name {get; set;} = string.Empty;
        [Required]
        public string Position {get; set;} = string.Empty;
        public string Department {get; set;} = string.Empty;
        public decimal Salary {get; set;} = decimal.Zero;
    }
