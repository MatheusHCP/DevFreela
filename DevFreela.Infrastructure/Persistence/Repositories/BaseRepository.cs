using DevFreela.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFreela.Infrastructure.Persistence.Repositories
{
    public class BaseRepository<T>
         : IDisposable, IBaseRepository<T> where T : class
    {
        private DevFreelaDbContext? _context;


        public T get(int id)
        {
            using (_context = new DevFreelaDbContext())
            {
                return _context.Set<T>().Find(id);
            }

        }

        public List<T> getAll()
        {
            using (_context = new DevFreelaDbContext())
            {
                return _context.Set<T>().ToList();
            }

        }

        public void add(T item)
        {
            using (_context = new DevFreelaDbContext())
            {
                _context.Set<T>().Add(item);
                _context.SaveChanges();
            }


        }

        public void delete(T item)
        {
            using (_context = new DevFreelaDbContext())
            {
                //_context.Set<T>().Remove(item);
                _context.Entry(item).State = EntityState.Deleted;
                _context.SaveChanges();
            }


        }

        public void edit(T item)
        {
            using (_context = new DevFreelaDbContext())
            {
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();
            }

        }

        public void Dispose()
        {
            using (_context = new DevFreelaDbContext())
            {
                _context.Dispose();
            }

        }
    }



}