namespace SalaryApp.Repositoris.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Salaries
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Salaries()
        {
            SalaryDetails = new HashSet<SalaryDetails>();
        }

        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int WorkplaceId { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public int EmployeesCount { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public bool IsLocked { get; set; }

        public virtual Companies Companies { get; set; }

        public virtual Workplaces Workplaces { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalaryDetails> SalaryDetails { get; set; }
    }
}
