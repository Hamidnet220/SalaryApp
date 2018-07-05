﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SalaryApp.Repositoris.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public DateTime? DOB { get; set; }
        public int? POBId { get; set; }
        public int? POIId { get; set; }
        public string NationalCode { get; set; }
        public string IdNumber { get; set; }
        public int? GenderId { get; set; }
        public Country Nationality { get; set; }
        public DateTime? HireDate { get; set; }
        public int? Experience { get; set; }
        public MilitaryServiceStatus MilitaryServiceStatus { get; set; }
        public int? MilitaryServiceStatusId { get; set; }
        //public int EducationDegreeId { get; set; }
        public int WorkplaceId { get; set; }
        //public int LaborStatus { get; set; }
        public bool MaritalStatus { get; set; }
        //public int? ComplimentaryInsId { get; set; }
        //public int ComplimentaryNumber { get; set; }
        public Insurance Insurance { get; set; }
        public int InsuranceId { get; set; }
        public string InsurenceNumber { get; set; }
        public int? BankName1Id { get; set; }
        public string BankAccNumber1 { get; set; }
        public int? BankName2Id { get; set; }
        public string BankAccNumber2 { get; set; }
        public int Children { get; set; }
        //public int? Education { get; set; }
        public int? Age { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public bool IsWorking { get; set; }
        public TaxGroup TaxGroup { get; set; }
        public InsuranceGroup InsuranceGroup { get; set; }

    }


}
