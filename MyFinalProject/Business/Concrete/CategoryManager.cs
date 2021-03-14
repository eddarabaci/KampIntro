using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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



        IDataResult<List<Category>> ICategoryService.GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.Listed);
        }
    }
}
