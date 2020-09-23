using System;
using System.Collections.Generic;
using System.Linq;

using ListaShop.Model.Base;
using ListaShop.Model.Context;
using Microsoft.EntityFrameworkCore;


namespace ListaShop.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MySqlContext _context;
        private DbSet<T> _dataset;

        public GenericRepository (MySqlContext context)
        {
            _context = context;
            _dataset = context.Set<T>();
        }

        public T Create(T item)
        {
            try
            {
                _dataset.Add(item);
                _context.SaveChanges();
                return item;
            }catch (Exception ex )
            {
                throw ex;
            }
        }

        public void Delete(long id)
        {
            var result = _dataset.SingleOrDefault(r => r.Id.Equals(id));

            try
            {
                if (result != null )
                {
                    _dataset.Remove(result);
                    _context.SaveChanges();
                }
            } catch (Exception ex )
            {
                throw ex;
            }
        }

        public bool Exists(long? id)
        {
            return _dataset.Any(b => b.Id.Equals(id));
        }

        public List<T> FindAll()
        {
            return _dataset.ToList();
        }

        public T FindById(long id)
        {            
            return _dataset.SingleOrDefault(r => r.Id.Equals(id));            
        }

        public T Update(T item)
        {
            if (!Exists(item.Id)) return null;

            var result = _dataset.SingleOrDefault(r => r.Id.Equals(item.Id));

            if (result == null) return null;

            try
            {
                _context.Entry(result).CurrentValues.SetValues(item);
                _context.SaveChanges();

                return item;
            }catch (Exception ex )
            {
                throw ex;
            }
        }          
    }
}
