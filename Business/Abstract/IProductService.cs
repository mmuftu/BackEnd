using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int productid);
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListByCategory(int categoryID);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
    }
}
