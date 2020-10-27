using Northwind.Business.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;

namespace Northwind.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {

        private ICategoryDal _categorydal;
        public CategoryManager(ICategoryDal category )
        {
            _categorydal = category;
        }
        public List<Category> GetAll()
        {
            return _categorydal.GetAll();
        }
    }
}
