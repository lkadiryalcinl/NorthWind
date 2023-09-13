using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<Category> GetByID(int categoryId)
        {
            var category = _categoryDal.Get(filter: p=> p.CategoryId == categoryId);
            return new SuccessDataResult<Category>(category);
        }

        IDataResult<List<Category>> ICategoryService.GetAll()
        {
            var list = _categoryDal.GetList();
            return new SuccessDataResult<List<Category>>(list);
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Messages.CATEGORY_ADDED);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.CATEGORY_DELETED);
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.CATEGORY_UPDATED);
        }
    }
}
