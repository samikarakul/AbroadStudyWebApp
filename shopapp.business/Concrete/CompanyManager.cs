using System.Collections.Generic;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private ICompanyRepository _companyRepository;
        public CompanyManager(ICompanyRepository companyRepository)
        {
            _companyRepository=companyRepository;
        }
        public string ErrorMessage { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public List<Company> GetAll()
        {
            return _companyRepository.GetAll();
        }
        public Company GetById(int id)
        {
          return _companyRepository.GetById(id);
        }
        public void Update(Company entity)
        {
             _companyRepository.Update(entity);
        }
        public bool Validation(Company entity)
        {
            throw new System.NotImplementedException();
        }
    }
}