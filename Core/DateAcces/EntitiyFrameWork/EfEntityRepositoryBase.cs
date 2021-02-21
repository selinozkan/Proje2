using Core.DataAccess;
using Core.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DateAcces.EntitiyFrameWork
{
   public class EfEntityRepositoryBase <TEnitiy,TContext>: IEntityRepository <TEnitiy>
   where TEnitiy:class, IEntity,new()
       where TContext:DbContext,new()
    
    {

        public void Add(TEnitiy entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }


        }

        public void Delete(TEnitiy entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEnitiy Get(Expression<Func<TEnitiy, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEnitiy>().SingleOrDefault(filter);
            }
        }

        public List<TEnitiy> GetAll(Expression<Func<TEnitiy, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEnitiy>().ToList()
                    : context.Set<TEnitiy>().Where(filter).ToList();
            }
        }

        public void Update(TEnitiy entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
