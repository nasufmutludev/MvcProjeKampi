using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetCategoryList();
        Category GetByID(int id);
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
