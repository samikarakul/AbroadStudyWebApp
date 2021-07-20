using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface IServeService:IValidator<Serve>
    {
         List<Serve> GetAll();
         void Update(Serve entity);
        void Create(Serve entity);

         Serve GetById(int id);
    }
}