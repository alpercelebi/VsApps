using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.Utilities.ValidationTool;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;
       
       
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {


            ValidationTool.validate(new ProductValidater(), product);
            _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public void Update(Product product)
        {
            ValidationTool.validate(new ProductValidater(), product);
            _productDal.Update(product);
        }
        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }
    }
}
