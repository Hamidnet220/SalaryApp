namespace SalaryApp.Repositoris.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Workplaces
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Workplaces()
        {
            Salaries = new HashSet<Salaries>();
        }

        public int Id { get; set; }

        public int CompanyId { get; set; }

        public bool IsAcitve { get; set; }

        public string Title { get; set; }

        public string EmployerTitle { get; set; }

        public string ContractNumber { get; set; }

        public decimal ContractPrice { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsClosed { get; set; }

        public string Tel { get; set; }

        public string Fax { get; set; }

        public string Address { get; set; }

        public DateTime CreateDate { get; set; }

        public int CreateByUserId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedDate { get; set; }

        public int? DeletedByUserID { get; set; }

        [StringLength(50)]
        public string InsuranceCode { get; set; }

        public virtual Companies Companies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salaries> Salaries { get; set; }
    }
}
