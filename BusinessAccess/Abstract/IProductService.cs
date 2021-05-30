using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessAccess.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetAllUnitPrice(decimal min , decimal max);
        List<ProductDetailDto> GetProductDetails();
    }
}
