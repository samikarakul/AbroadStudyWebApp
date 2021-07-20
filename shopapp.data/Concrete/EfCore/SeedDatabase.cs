using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategories);
                }
                if (context.Companies.Count() == 0)
                {
                    context.Companies.AddRange(Companies);
                }
                if (context.Serves.Count() == 0)
                {
                    context.Serves.AddRange(Serves);
                }
            }
            context.SaveChanges();
        }
        private static Category[] Categories = {
            new Category(){Name="Ukrayna",Url="ukrayna",CategoryImageUrl="1.jpg"},
            new Category(){Name="Rusya",Url="rusya",CategoryImageUrl="3.jpg"},
            new Category(){Name="Belarus",Url="belarus",CategoryImageUrl="4.jpg"},

        };
        private static Product[] Products = {
            new Product(){Name="Ukrayna Üniversitesi",Url="ukrayna-universite",ImageUrl="1.jpg",Description="Kiev'de bulunan bir üniversite", IsApproved=true},
            new Product(){Name="Belarus Üniversitesi",Url="belarus-universite",ImageUrl="3.jpg",Description="Belarus'da bulunan bir üniversite", IsApproved=true},
            new Product(){Name="Rusya Üniversitesi",Url="rusya-universite",ImageUrl="4.jpg",Description="Rusya'da bulunan bir üniversite", IsApproved=true},
        };
        private static Company[] Companies = 
        {
            new Company(){CompanyName="X Study",CompanyNumber="+90 0300 00 00", CompanyAdress="X Şehri X Mahallesi X Caddesi",CompanyEmail="mail@mail.com"}
        };
        private static Serve[] Serves = 
        {
            new Serve(){ServeName="Lisans Eğitimi", ServeDescription="Burada Lisans Eğitimi Hakkında Bilgi Verilecek", ServeImageUrl="1.jpg"},
            new Serve(){ServeName="Yurtdışı Dil Okulu", ServeDescription="Burada Dil Okullarının Eğitimi Hakkında Bilgi Verilecek", ServeImageUrl="2.jpg"}
        };
        private static ProductCategory[] ProductCategories={
            new ProductCategory(){Product=Products[0],Category=Categories[0]},
            new ProductCategory(){Product=Products[1],Category=Categories[2]},
            new ProductCategory(){Product=Products[2],Category=Categories[1]},
        };
    }
}