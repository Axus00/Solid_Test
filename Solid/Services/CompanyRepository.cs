using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solid.Data;
using Solid.Models;

namespace Solid.Services
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly CompanyDbContext _context;
        
        public CompanyRepository(CompanyDbContext context)
        {
            _context = context;
        }
        public void add(Company company, int id)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
        }

    
        public IEnumerable<Company> GetCompanies()
        {
            return _context.Companies.ToList();
        }

        public Company GetById(int id)
        {
            return _context.Companies.Find(id);
        }

        public void remove(int id)
        {
            var company = _context.Companies.Find(id);
            _context.Companies.Remove(company);
            _context.SaveChanges();
        }

        public void update(Company company, int id)
        {
            var com = _context.Companies.Find(id);
            _context.Companies.Update(com);
            _context.SaveChanges();
        }

    }
}