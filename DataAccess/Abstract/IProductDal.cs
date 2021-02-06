using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //IEntityRepository de genereic bir yapı oluşturduk oraya ne yazarsak onu kullanır

        List<ProductDetailDto> GetProductDetails();
    }
}
//Code refactoring