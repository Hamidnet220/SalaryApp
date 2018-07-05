namespace SalaryApp.Repositoris.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SalaryDetails
    {
        public int Id { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal NetAmount { get; set; }

        public int SalaryId { get; set; }

        public int? Employee_Id { get; set; }

        public virtual Employees Employees { get; set; }

        public virtual Salaries Salaries { get; set; }
    }
}
