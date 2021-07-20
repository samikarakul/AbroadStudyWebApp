using System.Collections.Generic;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.business.Concrete
{
    public class ServeManager : IServeService
    {
        private IServeRepository _serveRepository;
        public ServeManager(IServeRepository serveRepository)
        {
            _serveRepository=serveRepository;
        }
        public string ErrorMessage { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public void Create(Serve entity)
        {
           _serveRepository.Create(entity);
        }
        public List<Serve> GetAll()
        {
             return _serveRepository.GetAll();
        }
        public Serve GetById(int id)
        {
             return _serveRepository.GetById(id);
        }
        public void Update(Serve entity)
        {
            _serveRepository.Update(entity);
        }
        public bool Validation(Serve entity)
        {
            throw new System.NotImplementedException();
        }
    }
}