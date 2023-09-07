using StockTakip.WebAPP.Models;

namespace StockTakip.WebAPP.Repository
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
       
    }
}
