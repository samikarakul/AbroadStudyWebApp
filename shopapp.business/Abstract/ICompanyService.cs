using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface ICompanyService:IValidator<Company>
    {
         List<Company> GetAll();
         void Update(Company entity);
         Company GetById(int id);

    }
}