using System.Collections.Generic;
using ListaShop.Model;

namespace ListaShop.Services
{
    public interface IPersonService
    {
        Person Create(Person person);

        List<Person> Get();

        Person GetById(long id);

        void Delete(long id);

        Person Update(Person person);
    }
}
