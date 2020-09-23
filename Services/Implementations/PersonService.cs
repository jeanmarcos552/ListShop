using System.Collections.Generic;

using ListaShop.Model;
using ListaShop.Repository.Generic;

namespace ListaShop.Services.Implementations
{
    public class PersonService : IPersonService
    {
        private IRepository<Person> _repository;

        public PersonService (IRepository<Person> repository)
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
      
        public List<Person> Find()
        {
            return _repository.FindAll();
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);           
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);            
        }
    }
}
