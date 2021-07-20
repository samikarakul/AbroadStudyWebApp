using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using shopapp.business.Abstract;
using shopapp.entity;
using shopapp.webui.Identity;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    [Authorize]
    public class AdminController: Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;
        private ICompanyService _companyService;
        private IServeService _serveService;
        public AdminController(IProductService productService,ICategoryService categoryService, RoleManager<IdentityRole> roleManager
                                ,UserManager<User> userManager,ICompanyService companyService,IServeService serveService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _companyService=companyService;
            _serveService=serveService;
            _roleManager=roleManager;
            _userManager=userManager;
            
        }
        public IActionResult ProductList()
        {
            return View(new ProductListViewModel()
            {
                Products = _productService.GetAll()
            });
        }
        public IActionResult CategoryList()
        {
            return View(new CategoryListViewModel()
            {
                Categories = _categoryService.GetAll()
            });
        }
        public IActionResult CompanyList()
        {
            return View(new CompanyListViewModel()
            {
                Companies = _companyService.GetAll()
            });
        }
        [HttpGet]
        public IActionResult ProductCreate()
        {
             var model = new ProductModel()
            {
                Name="",
                Url= "",
                ImageUrl= "",
                Description = "",
            };
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProductCreate(ProductModel model,IFormFile file)
        {
            if(ModelState.IsValid)
            {
                var entity = new Product()
                {
                    Name = model.Name,
                    Url = model.Url,
                    Description = model.Description,
                };
                if(file!=null)
                    {
                        var extention = Path.GetExtension(file.FileName );
                        var randomName=string.Format($"{Guid.NewGuid()}{extention}"); //github
                        entity.ImageUrl=randomName;
                        var path=Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\img",randomName);
                        using(var stream = new FileStream(path,FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                    }    
                if(_productService.Create(entity))
                {                    
                    return RedirectToAction("ProductList");
                }
                return View(model);
            }            
            return View(model);         
        }

         [HttpGet]
        public IActionResult CategoryCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryCreate(CategoryModel model)
        {
             if(ModelState.IsValid)
            {
                var entity = new Category()
                {
                    Name = model.Name,
                    Url = model.Url,
                    CategoryImageUrl=model.CategoryImageUrl
                };
                _categoryService.Create(entity);
                var msg = new AlertMessage()
                {            
                    Message = $"{entity.Name} isimli category eklendi.",
                    AlertType = "success"
                };
                TempData["message"] =  JsonConvert.SerializeObject(msg);
                return RedirectToAction("CategoryList");
            }
            return View(model);
        }

        //SERVE İŞLEMLERİ


        public IActionResult ServeList()
        {
            return View(new ServeListViewModel()
            {
                Serves = _serveService.GetAll()
            });
        }
          [HttpGet]
        public IActionResult ServeCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ServeCreate(ServeModel model)
        {
             if(ModelState.IsValid)
            {
                var entity = new Serve()
                {
                    ServeName = model.ServeName,
                    ServeDescription = model.ServeDescription,
                    ServeImageUrl=model.ServeImageUrl
                };
                _serveService.Create(entity);
                var msg = new AlertMessage()
                {            
                    Message = $"{entity.ServeName} isimli category eklendi.",
                    AlertType = "success"
                };
                TempData["message"] =  JsonConvert.SerializeObject(msg);
                return RedirectToAction("ServeList");
            }
            return View(model);
        }
        //serve edit
          [HttpGet]
        public IActionResult ServeEdit(int? id)
        {
            if(id==null)
            {
                return RedirectToAction("Hata","Home");
            }
            var entity = _serveService.GetById((int)id);
            if(entity==null)
            {
                 return RedirectToAction("Hata","Home");
            }
            var model = new ServeModel()
            {
                ServeId = entity.ServeId,
                ServeName = entity.ServeName,
                ServeDescription=entity.ServeDescription,
                ServeImageUrl = entity.ServeImageUrl
            };
            return View(model);
        }
        
        [HttpPost]
        public async Task<IActionResult> ServeEdit(ServeModel model,IFormFile file)
        {
            if(ModelState.IsValid)
            {
                var entity = _serveService.GetById(model.ServeId);
                if(entity==null)
                {
                    return RedirectToAction("Hata","Home");
                }
                entity.ServeName = model.ServeName;
                entity.ServeDescription=model.ServeDescription;
                if(file!=null)
                {
                    var extention = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                    entity.ServeImageUrl = randomName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\img",randomName);
                    using(var stream = new FileStream(path,FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                _serveService.Update(entity);
                var msg = new AlertMessage()
                {            
                    Message = $"{entity.ServeName} isimli serve güncellendi.",
                    AlertType = "success"
                };
                TempData["message"] =  JsonConvert.SerializeObject(msg);
                return RedirectToAction("ServeList");
            }

            return View(model);
        }
      
        [HttpGet]
        public IActionResult ProductEdit(int? id)
        {
            if(id==null)
            {
                return RedirectToAction("Hata","Home");
            }
            var entity = _productService.GetByIdWithCategories((int)id);
            if(entity==null)
            {
                 return RedirectToAction("Hata","Home");
            }
            var model = new ProductModel()
            {
                ProductId = entity.ProductId,
                Name = entity.Name,
                Url = entity.Url,
                ImageUrl= entity.ImageUrl,
                Description = entity.Description,
                IsApproved = entity.IsApproved,
                IsHome = entity.IsHome,
                SelectedCategories = entity.ProductCategories.Select(i=>i.Category).ToList()
            };
            ViewBag.Categories = _categoryService.GetAll();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ProductEdit(ProductModel model,int[] categoryIds,IFormFile file)
        {
            if(ModelState.IsValid)
            {        
                var entity = _productService.GetById(model.ProductId);
                if(entity==null)
                {
                    return RedirectToAction("Hata","Home");
                }
                entity.Name = model.Name;
                entity.Url = model.Url;
                entity.Description = model.Description;
                entity.IsHome = model.IsHome;
                entity.IsApproved = model.IsApproved;
                if(file!=null)
                {
                    var extention = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                    entity.ImageUrl = randomName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\img",randomName);
                    using(var stream = new FileStream(path,FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                if(_productService.Update(entity,categoryIds))
                {                    
                    CreateMessage("kayıt güncellendi","success");
                    return RedirectToAction("ProductList");
                }
                CreateMessage(_productService.ErrorMessage,"danger");
            }
            ViewBag.Categories = _categoryService.GetAll();
            return View(model);
        }
        [HttpGet]
        public IActionResult CategoryEdit(int? id)
        {
            if(id==null)
            {
                return RedirectToAction("Hata","Home");
            }
            var entity = _categoryService.GetByIdWithProducts((int)id);
            if(entity==null)
            {
                 return RedirectToAction("Hata","Home");
            }
            var model = new CategoryModel()
            {
                CategoryId = entity.CategoryId,
                Name = entity.Name,
                Url = entity.Url,
                CategoryImageUrl = entity.CategoryImageUrl,
                Products = entity.ProductCategories.Select(p=>p.Product).ToList()
            };
            return View(model);
        }
        
        [HttpPost]
        public async Task<IActionResult> CategoryEdit(CategoryModel model,IFormFile file)
        {
            if(ModelState.IsValid)
            {
                Console.WriteLine("ilk basamak");
                var entity = _categoryService.GetById(model.CategoryId);
                if(entity==null)
                {
                    return RedirectToAction("Hata","Home");
                }
                entity.Name = model.Name;
                entity.Url = model.Url;
                if(file!=null)
                {
                    var extention = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                    entity.CategoryImageUrl = randomName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\img",randomName);
                    using(var stream = new FileStream(path,FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                _categoryService.Update(entity);
                var msg = new AlertMessage()
                {            
                    Message = $"{entity.Name} isimli category güncellendi.",
                    AlertType = "success"
                };
                TempData["message"] =  JsonConvert.SerializeObject(msg);
                return RedirectToAction("CategoryList");
            }
            return View(model);
        }
       
        //COMPANY
        [HttpGet]
        public IActionResult CompanyEdit(int? id)
        {
            if(id==null)
            {
                return RedirectToAction("Hata","Home");
            }
            var entity = _companyService.GetById((int)id);
            if(entity==null)
            {
                 return RedirectToAction("Hata","Home");
            }
            var model = new CompanyModel()
            {
                CompanyId = entity.CompanyId,
                CompanyName = entity.CompanyName,
                CompanyNumber = entity.CompanyNumber,
                CompanyAdress=entity.CompanyAdress,
                CompanyEmail=entity.CompanyEmail
            };
            return View(model);
        }
        
         [HttpPost]
        public IActionResult CompanyEdit(CompanyModel model)
        {
            if(ModelState.IsValid)
            {
                var entity = _companyService.GetById(model.CompanyId);
                if(entity==null)
                {
                    return RedirectToAction("Hata","Home");
                }
                entity.CompanyName = model.CompanyName;
                entity.CompanyAdress = model.CompanyAdress;
                entity.CompanyNumber = model.CompanyNumber;
                entity.CompanyEmail = model.CompanyEmail;
                _companyService.Update(entity);
                return RedirectToAction("CompanyList");
            }
            Console.WriteLine("model geldi");
            return View(model);
        }
        public IActionResult DeleteProduct(int productId)
        {
            var entity = _productService.GetById(productId);
            if(entity!=null)
            {
                _productService.Delete(entity);
            }
              var msg = new AlertMessage()
            {            
                Message = $"{entity.Name} isimli ürün silindi.",
                AlertType = "danger"
            };
            TempData["message"] =  JsonConvert.SerializeObject(msg);
            return RedirectToAction("ProductList");
        }
        
        public IActionResult DeleteCategory(int categoryId)
        {
            var entity = _categoryService.GetById(categoryId);

            if(entity!=null)
            {
                _categoryService.Delete(entity);
            }
              var msg = new AlertMessage()
            {            
                Message = $"{entity.Name} isimli category silindi.",
                AlertType = "danger"
            };
            TempData["message"] =  JsonConvert.SerializeObject(msg);
            return RedirectToAction("CategoryList");
        }
    
        [HttpPost]
        public IActionResult DeleteFromCategory(int productId,int categoryId)
        {
            _categoryService.DeleteFromCategory(productId,categoryId);
            return Redirect("/admin/categories/"+categoryId);
        }
        private void CreateMessage(string message,string alerttype)
        {
            var msg = new AlertMessage()
            {            
                Message = message,
                AlertType = alerttype
            };
            TempData["message"] =  JsonConvert.SerializeObject(msg);
        }
       
    }
}