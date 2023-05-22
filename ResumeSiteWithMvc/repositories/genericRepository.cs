using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using ResumeSiteWithMvc.Models.entity;
namespace ResumeSiteWithMvc.repositories
{
    public class genericRepository<C> where C : class, new()
    {
        resumeEntities1 db = new resumeEntities1();
        public List<C> list()
        {
            return db.Set<C>().ToList();
        }
        public void add(C p)
        {
            db.Set<C>().Add(p);
            db.SaveChanges();
        }
        public void delete(C p)
        {
            db.Set<C>().Remove(p);
            db.SaveChanges();
        }
        public C get(int id)
        {
          return db.Set<C>().Find(id);

        }
        public void update(C p)
        {
           db.SaveChanges();
        }
        public C find(Expression<Func<C, bool>> where)
        {
            return db.Set<C>().FirstOrDefault(where);
        }
    }
}
