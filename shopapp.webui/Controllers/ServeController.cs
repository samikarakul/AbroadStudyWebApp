using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class ServeController:Controller
    {
        private IServeService _serveService;
        public ServeController(IServeService serveService)
        {
            this._serveService=serveService;
        }
        public IActionResult Index()
        {
            var serveViewModel = new ServeListViewModel()
            {
                Serves = _serveService.GetAll()
            };
            return View(serveViewModel);
        }
    }
}