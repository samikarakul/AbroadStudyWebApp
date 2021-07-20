using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;

namespace shopapp.webui.ViewComponents
{
    public class CompaniesViewComponent: ViewComponent
    {
        private ICompanyService _companyService;
        public CompaniesViewComponent(ICompanyService companyService)
        {
            this._companyService=companyService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_companyService.GetAll());
        }
    }
}