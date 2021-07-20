using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Identity;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class AccountController: Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager=userManager;
            _signInManager=signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByNameAsync(model.UserName);
            if(user==null)
            {
                ModelState.AddModelError("","Böyle bir kullanıcı tanımlı değil!");
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(user,model.Password,false,false);
            if(result.Succeeded)
            {
                return RedirectToAction("Index","Home");
            }
            ModelState.AddModelError("","Kullanıcı adı veya parola yanlış");
            return View(model);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            var user=new User()
            {
                FirstName=model.FirstName,
                LastName=model.LastName,
                UserName=model.UserName
            };
            var result= await _userManager.CreateAsync(user,model.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("Login","Account");
            }
            ModelState.AddModelError("","Bilinmeyen hata oluştu.Tekrar dene.");
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }
    }
}