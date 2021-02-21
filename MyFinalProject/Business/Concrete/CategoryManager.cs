using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;  //generate constructor

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //business codes
            //
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            //Select * from Categories where CategoryId = 3
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
