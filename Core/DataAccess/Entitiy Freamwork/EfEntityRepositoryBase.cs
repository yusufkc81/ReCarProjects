using DataAccess.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.PeerToPeer;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Entitiy_Freamwork
{
    public class EfEntityRepositoryBase<TEntity, TContext>: IEntityRepository<TEntity>
        where TEntity: class, ICar, new ()
        where TContext : DbContext,new ()
    {

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity =context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(TEntity entity)
        {
           using(TContext context = new TContext())
            {
                var deletedEntity =context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using(var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }


        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter ==null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }
        //FileNotFoundException: Could not load file or assembly 'System.Diagnostics.PerformanceCounter,
        //Version=4.0.2.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'. Sistem belirtilen dosyayı bulamıyor.


        public void Update(TEntity entity)
        {
            using(TContext context=new TContext())
            {
               var updateEntity=context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
