using StockTakip.WebAPP.Models;

namespace StockTakip.WebAPP.Repository
{
    public interface ICategoryRepository
    {

        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
        Category GetById(int id);
        List<Category> GetAll();






    }
}
