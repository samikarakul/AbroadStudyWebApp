using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public class EfCoreServeRepository: EfCoreGenericRepository<Serve, ShopContext>, IServeRepository
    {
        
    }
}