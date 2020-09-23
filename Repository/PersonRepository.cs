using System;
using ListaShop.Model.Context;
using ListaShop.Model;
using System.Linq;
using System.Collections.Generic;


namespace ListaShop.Repository
{
    public class PersonRepository
    {
        private MySqlContext _context;

        public PersonRepository(MySqlContext context)
        {
            _context = context;
        }


        public Person Create(Person person)
        {
            try
            {
                _context.Add<Person>(person);
                _context.SaveChanges();

                return person;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Delete(long id)
        {
            var person = _context.Person.SingleOrDefault(p => p.Id.Equals(id));

            try
            {
                if (person != null)
                {
                    _context.Person.Remove(person);
                    _context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Person> FindAll()
        {
            return _context.Person.ToList<Person>();
        }

        public Person FindById(long id)
        {
            var person = _context.Person.SingleOrDefault(p => p.Id.Equals(id));

            try
            {
                return person;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Person Update(Person person)
        {
            var isPerson = _context.Person.SingleOrDefault(p => p.Id.Equals(person.Id));


            if (isPerson == null) return person;

            try
            {
                _context.Entry(isPerson).CurrentValues.SetValues(person);
                _context.SaveChanges();
                return person;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
