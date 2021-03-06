﻿using System;
using System.Collections.Generic;

namespace SalaryApp.Repositoris.Entities
{
    public class Workplace
    {
        public int Id { get; set; }
        public virtual Company Company { get; set; }
        public int CompanyId { get; set; }
        public string InsuranceCode { get; set; }
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
        public int? DeletedByUserId { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
    }
}
