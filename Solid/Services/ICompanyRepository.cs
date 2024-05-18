using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Solid.Models;


namespace Solid.Services
{
    public interface ICompanyRepository
    {
        //obtener todo
        IEnumerable<Company> GetCompanies();
        //por id
        Company GetById(int id);
        //editar
        void add(Company company, int id);
        //eliminar
        void remove(int id);
        //actualizar
        void update(Company company, int id);
    }
}