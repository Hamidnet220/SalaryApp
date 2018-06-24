using System;
using System.Collections.Generic;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.Repositoris.RpositoryInterfaces
{
    public interface ICompanyRepository :IRepository<Company>
    {
        IEnumerable<Company> GetById(int value);
        IEnumerable<Company> GetByTitle(string value);
        IEnumerable<Company> GetByTel(string value);
        IEnumerable<Company> GetByFax(string value);
        IEnumerable<Company> GetByAddress(string value);
        IEnumerable<Company> GetByCreateDate(DateTime value);
        IEnumerable<Company> GetByCreateByUserId(int value);
        IEnumerable<Company> GetByIsDeleted(bool value);
        IEnumerable<Company> GetByDeletedDate(DateTime? value);
        IEnumerable<Company> GetByDeletedByUserID(int? value);
    }
}
