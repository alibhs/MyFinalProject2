using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessAccess.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId);
    }
}
