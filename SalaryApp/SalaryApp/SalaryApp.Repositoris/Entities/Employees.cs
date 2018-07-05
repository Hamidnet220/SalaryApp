namespace SalaryApp.Repositoris.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees()
        {
            SalaryDetails = new HashSet<SalaryDetails>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public string FatherName { get; set; }

        public DateTime? DOB { get; set; }

        [Required]
        [StringLength(10)]
        public string NationalCode { get; set; }

        [Required]
        [StringLength(10)]
        public string IdNumber { get; set; }

        public DateTime? HireDate { get; set; }

        public int? Experience { get; set; }

        public int? Nationality_Id { get; set; }

        [StringLength(50)]
        public string BankAccNumber1 { get; set; }

        [StringLength(50)]
        public string BankAccNumber2 { get; set; }

        public int Children { get; set; }

        public int? Age { get; set; }

        public string Tel { get; set; }

        public string Mobile { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public bool IsWorking { get; set; }

        public int? BankName1Id { get; set; }

        public int? BankName2Id { get; set; }

        public int? POBId { get; set; }

        public int? POIId { get; set; }

        public int? GenderId { get; set; }

        public bool MaritalStatus { get; set; }

        public int WorkplaceId { get; set; }

        public int? MilitaryServiceStatusId { get; set; }

        [StringLength(10)]
        public string InsurenceNumber { get; set; }

        public int? InsuranceId { get; set; }

        public virtual Banks Banks { get; set; }

        public virtual Banks Banks1 { get; set; }

        public virtual Cities Cities { get; set; }

        public virtual Cities Cities1 { get; set; }

        public virtual Countries Countries { get; set; }

        public virtual Genders Genders { get; set; }

        public virtual Insurances Insurances { get; set; }

        public virtual MilitaryServiceStatus MilitaryServiceStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalaryDetails> SalaryDetails { get; set; }
    }
}
