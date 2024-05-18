using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solid.Services;
using Solid.Models;

namespace Solid.Controllers
{
    
    [ApiController]
    [Route("api/[companies]")]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;
        public CompaniesController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        [HttpGet]
        [Route("listar")]
        //listar
        public IEnumerable<Company> GetUsers(){
            return _companyRepository.GetCompanies();
        }
        [HttpGet]
        [Route("listar/{id}")]
        //Detalles
        public Company Details(int id)
        {
            return _companyRepository.GetById(id);
        }
    }
}