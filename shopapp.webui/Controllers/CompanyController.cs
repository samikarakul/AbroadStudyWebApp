using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class CompanyController: Controller
    {
        private ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            this._companyService=companyService;
        }
        public IActionResult Index()
        {
            var companyViewModel = new CompanyListViewModel()
            {
                Companies = _companyService.GetAll()
            };

            return View(companyViewModel);
        }

     
    }
}