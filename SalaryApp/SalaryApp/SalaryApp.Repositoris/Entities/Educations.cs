namespace SalaryApp.Repositoris.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Educations
    {
        public int Id { get; set; }

        public string Title { get; set; }
    }
}
