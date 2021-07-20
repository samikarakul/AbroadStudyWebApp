using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using shopapp.business.Abstract;
using shopapp.business.Concrete;
using shopapp.data.Abstract;
using shopapp.data.Concrete.EfCore;
using shopapp.webui.Identity;

namespace shopapp.webui
{
    public class Startup
    {
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration=configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options=> options.UseSqlite("Data Source=studyDb"));
            services.AddIdentity<User,IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options=>{
                options.Password.RequireDigit=true;
            });
            services.ConfigureApplicationCookie(options=>{
                options.LoginPath="/account/login";
                options.LogoutPath="/account/logout";
               
                 options.Cookie = new CookieBuilder
                {
                    HttpOnly = true, // sadece htpp ile cookie ye erişilir
                    Name = ".shopapp.Security.Cookie" // cookie adı
                    
                };
            });
            services.AddScoped<ICategoryRepository,EfCoreCategoryRepository>(); 
            services.AddScoped<IProductRepository,EfCoreProductRepository>(); 
            services.AddScoped<ICompanyRepository,EfCoreCompanyRepository>(); 
            services.AddScoped<IServeRepository,EfCoreServeRepository>(); 

            services.AddScoped<IProductService,ProductManager>(); 
            services.AddScoped<ICategoryService,CategoryManager>(); 
            services.AddScoped<ICompanyService,CompanyManager>(); 
            services.AddScoped<IServeService,ServeManager>(); 

            services.AddControllersWithViews();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration,UserManager<User> userManager,RoleManager<IdentityRole> roleManager)
        {
            app.UseStaticFiles(); // wwwroot
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {     
                endpoints.MapControllerRoute(
                    name: "adminproducts", 
                    pattern: "admin/products",
                    defaults: new {controller="Admin",action="ProductList"}
                );
                endpoints.MapControllerRoute(
                    name: "adminproductcreate", 
                    pattern: "admin/products/create",
                    defaults: new {controller="Admin",action="ProductCreate"}
                );
                endpoints.MapControllerRoute(
                    name: "adminproductedit", 
                    pattern: "admin/products/{id?}",
                    defaults: new {controller="Admin",action="ProductEdit"}
                );
                 endpoints.MapControllerRoute(
                    name: "admincategories", 
                    pattern: "admin/categories",
                    defaults: new {controller="Admin",action="CategoryList"}
                );
                endpoints.MapControllerRoute(
                    name: "admincategorycreate", 
                    pattern: "admin/categories/create",
                    defaults: new {controller="Admin",action="CategoryCreate"}
                );

                endpoints.MapControllerRoute(
                    name: "admincategoryedit", 
                    pattern: "admin/categories/{id?}",
                    defaults: new {controller="Admin",action="CategoryEdit"}
                );
                //serve
                endpoints.MapControllerRoute(
                    name: "adminserves", 
                    pattern: "admin/serves",
                    defaults: new {controller="Admin",action="ServeList"}
                );
                endpoints.MapControllerRoute(
                    name: "adminserveedit", 
                    pattern: "admin/serves/{id?}",
                    defaults: new {controller="Admin",action="ServeEdit"}
                );
                endpoints.MapControllerRoute(
                    name: "adminservecreate", 
                    pattern: "admin/serves/create",
                    defaults: new {controller="Admin",action="ServeCreate"}
                );
                //company
                endpoints.MapControllerRoute(
                    name: "admincompanies", 
                    pattern: "admin/companies",
                    defaults: new {controller="Admin",action="CompanyList"}
                );
                endpoints.MapControllerRoute(
                    name: "admincompanyedit", 
                    pattern: "admin/companies/{id?}",
                    defaults: new {controller="Admin",action="CompanyEdit"}
                );
                endpoints.MapControllerRoute(
                    name: "admincompanies", 
                    pattern: "admin/companies",
                    defaults: new {controller="Admin",action="CompanyList"}
                );
                endpoints.MapControllerRoute(
                    name: "search", 
                    pattern: "search",
                    defaults: new {controller="Shop",action="search"}
                );
                endpoints.MapControllerRoute(
                    name: "productdetails", 
                    pattern: "{url}",
                    defaults: new {controller="Shop",action="details"}
                );
                endpoints.MapControllerRoute(
                    name: "products", 
                    pattern: "universiteler/{category?}",
                    defaults: new {controller="Shop",action="list"}
                );
                 endpoints.MapControllerRoute(
                    name: "Index", 
                    pattern: "hakkimizda/{category?}",
                    defaults: new {controller="Company",action="Index"}
                );

                endpoints.MapControllerRoute(
                    name: "products", 
                    pattern: "ulkeler/{category?}",
                    defaults: new {controller="Home",action="MyView"}
                );
                endpoints.MapControllerRoute(
                    name: "Index", 
                    pattern: "programlar/{category?}",
                    defaults: new {controller="Serve",action="Index"}
                );
                endpoints.MapControllerRoute(
                    name: "MyView", 
                    pattern: "ulkeler",
                    defaults: new {controller="Home",action="MyView"}
                );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern:"{controller=Home}/{action=Index}/{id?}"
                );
            });
            SeedIdentity.Seed(userManager,roleManager,configuration).Wait();
        }
    }
}
