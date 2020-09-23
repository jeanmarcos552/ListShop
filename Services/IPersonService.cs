using System.Collections.Generic;
using ListaShop.Model;


namespace ListaShop.Services
{
    public interface IPersonService
    {
        Person Create(Person person);

        List<Person> Find();

        Person FindById(long id);

        void Delete(long id);

        Person Update(Person person);
    }
}
