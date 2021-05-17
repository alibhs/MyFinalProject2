using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessAccess.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
