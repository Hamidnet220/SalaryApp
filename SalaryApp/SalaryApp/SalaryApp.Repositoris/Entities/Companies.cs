namespace SalaryApp.Repositoris.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Companies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Companies()
        {
            Salaries = new HashSet<Salaries>();
            Workplaces = new HashSet<Workplaces>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Tel { get; set; }

        public string Fax { get; set; }

        public string Address { get; set; }

        public DateTime CreateDate { get; set; }

        public int CreateByUserId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedDate { get; set; }

        public int? DeletedByUserID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salaries> Salaries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Workplaces> Workplaces { get; set; }
    }
}
