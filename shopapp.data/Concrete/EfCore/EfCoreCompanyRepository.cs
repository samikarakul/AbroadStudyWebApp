using System.Linq;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public class EfCoreCompanyRepository: EfCoreGenericRepository<Company, ShopContext>, ICompanyRepository
    {
       
    }
}