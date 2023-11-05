using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        public void TAdd(Product entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Product TGetId(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
