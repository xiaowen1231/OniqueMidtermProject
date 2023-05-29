namespace Onique.EStore.SqlDataLayer.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployeeName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(250)]
        public string Email { get; set; }

        public bool Gender { get; set; }

        public int Citys { get; set; }

        public int Areas { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Required]
        [StringLength(50)]
        public string Position { get; set; }

        [StringLength(250)]
        public string PhotoPath { get; set; }

        public DateTime RegisterDate { get; set; }

        public virtual Area Area { get; set; }

        public virtual City City { get; set; }
    }
}
