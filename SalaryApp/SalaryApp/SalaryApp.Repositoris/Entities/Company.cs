using System;
using System.Collections.Generic;

namespace SalaryApp.Repositoris.Entities

{
    public class Company
    {
        public int Id {get;set;}
        public string Title {get;set;}
        public string Tel {get;set;}
        public string Fax {get;set;}
        public string Address {get;set;}
        public DateTime CreateDate {get;set;}
        public int CreateByUserId {get;set;}
        public bool IsDeleted {get;set;}
        public DateTime? DeletedDate {get;set;}
        public int? DeletedByUserId {get;set;}

        public virtual ICollection<Workplace> Workplaces { get; set; }
    }
}
