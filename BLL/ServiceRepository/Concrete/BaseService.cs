using BLL.ServiceRepository.Absract;
using DataAccess.Context;
using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceRepository.Concrete
{
    public class BaseService<T> : IService<T> where T : BaseClass
    {
        SınıfDbContext db = new SınıfDbContext();
        public string Create(T model)
        {
            db.Set<T>().Add(model);
            db.SaveChanges();
            return "Veri kaydedildi.";
        }

        public string Delete(int Id)
        {
            db.Set<T>().Remove(GetById(Id));
            db.SaveChanges();
            return "Veri silindi.";
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(int Id)
        {
            T entity = db.Set<T>().Find(Id);
            return entity;
        }

        public string Update(T model)
        {
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return "Veri güncellendi.";
        }

       
    }
}
