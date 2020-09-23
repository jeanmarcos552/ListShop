using System;
using System.Collections.Generic;
using ListaShop.Model;
using ListaShop.Repository.Generic;

namespace ListaShop.Services.Implementations
{
    public class ShopService : IShopService
    {

        private IRepository<Shop> _repository;

        public ShopService(IRepository<Shop> repository) {
            _repository = repository;
        }

        public Shop Create(Shop shop)
        {
            return _repository.Create(shop);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public Shop FindById(long id)
        {
            return _repository.FindById(id);
        }

        public List<Shop> FindAll()
        {
            return _repository.FindAll();
        }

        public Shop Update(Shop shop)
        {
            return _repository.Update(shop);
        }
    }
}
