using System;
using System.Collections.Generic;
using System.Linq;
using SalaryApp.Repositoris.Entities;
using SalaryApp.Repositoris.RpositoryInterfaces;

namespace SalaryApp.Repositoris.Repositories
{
    public class CompanyRepository:Repository<Company>,ICompanyRepository
    {
        public CompanyRepository(SalaryAppContext context):base(context)
        {
            
        }

        public SalaryAppContext SalaryAppContext
        {
            get { return Context as SalaryAppContext; }
        }

        public IEnumerable<Company> GetById(int value)
        {
            return SalaryAppContext.Companies.Where(c => c.Id == value).ToList();
        }

        public IEnumerable<Company> GetByTitle(string value)
        {
            return SalaryAppContext.Companies.Where(c => c.Title == value).ToList();
        }

        public IEnumerable<Company> GetByTel(string value)
        {
            return SalaryAppContext.Companies.Where(c=>c.Tel==value);
        }

        public IEnumerable<Company> GetByFax(string value)
        {
            return  SalaryAppContext.Companies.Where(c=>c.Fax==value);
        }

        public IEnumerable<Company> GetByAddress(string value)
        {
            return SalaryAppContext.Companies.Where(c => c.Address == value);
        }

        public IEnumerable<Company> GetByCreateDate(DateTime value)
        {
           return SalaryAppContext.Companies.Where(c=>c.CreateDate==value);
        }

        public IEnumerable<Company> GetByCreateByUserId(int value)
        {
            return SalaryAppContext.Companies.Where(c=>c.CreateByUserId==value);
        }

        public IEnumerable<Company> GetByIsDeleted(bool value)
        {
            return SalaryAppContext.Companies.Where(c=>c.IsDeleted==value);
        }

        public IEnumerable<Company> GetByDeletedDate(DateTime? value)
        {
            return SalaryAppContext.Companies.Where(c => c.DeletedDate == value);
        }

        public IEnumerable<Company> GetByDeletedByUserID(int? value)
        {
            return SalaryAppContext.Companies.Where(c=>c.DeletedByUserId==value);
        }
    }
}
