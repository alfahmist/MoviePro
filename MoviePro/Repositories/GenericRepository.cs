using Microsoft.EntityFrameworkCore;
using MoviePro.Models;
using MoviePro.Repositories.Data;
using MoviePro.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Repositories
{
    public class GenericRepository<Entity, TContext, TId> : IGenericRepository<Entity, TId>
      where Entity : class
      where TContext : MovieDBContext
    {
        private readonly MovieDBContext context;
        private MovieDBContext myContext;

        public GenericRepository(MovieDBContext context)
        {
            this.context = context;
        }

        public int Delete(TId Id)
        {
            var deleted = GetById(Id);
            context.Set<Entity>().Remove(deleted);
            var result = context.SaveChanges();
            return result;
        }

        public IEnumerable<Entity> GetAll()
        {
            var get = context.Set<Entity>().ToList();
            return get;
        }

        public Entity GetById(TId Id)
        {
            var GetById = context.Set<Entity>().Find(Id);
            return GetById;
        }

        public int Post(Entity obj)
        {
            context.Set<Entity>().Add(obj);
            var result = context.SaveChanges();
            return result;
        }

        public int Put(Entity obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            var result = context.SaveChanges();
            return result;
        }
    }
}
