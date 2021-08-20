using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public abstract class BaseRepository<M> where M : Base
    {
        public virtual void Create(M model)
        {
            using(var context = new BaseContext())
            {
                context.Set<M>().Add(model);
                context.SaveChanges();
            }
        }
        public virtual List<M> Read()
        {
            using (var context = new BaseContext())
            {
                return context.Set<M>().ToList();
            }
        }
        public virtual M Read(int id)
        {
            using (var context = new BaseContext())
            {
                return context.Set<M>().Find(id);
            }
        }
        public virtual void Update(M model)
        {
            using (var context = new BaseContext())
            {
                context.Entry(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public virtual void Delete(int id)
        {
            using (var context = new BaseContext())
            {
                context.Entry(Read(id)).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
