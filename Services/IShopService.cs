using System;
using ListaShop.Model;
using System.Collections.Generic;

namespace ListaShop.Services
{
    public interface IShopService
    {
        Shop Create(Shop shop);

        List<Shop> FindeAll();

        Shop FindById(long id);

        void Delete(long id);

        Shop Update(Shop shop);
    }
}
