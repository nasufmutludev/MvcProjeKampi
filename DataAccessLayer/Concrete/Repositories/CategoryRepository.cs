using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _category;
        public void Delete(Category category)
        {
            _category.Remove(category);
            c.SaveChanges();
        }

        public void Insert(Category category)
        {
            _category.Add(category);
            c.SaveChanges();
        }

        public List<Category> List()
        {
            return _category.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            c.SaveChanges();
        }
    }
}
