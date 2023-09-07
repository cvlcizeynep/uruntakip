using StockTakip.WebAPP.Models;

namespace StockTakip.WebAPP.Repository
{
    public class ProductRepository : IProductRepository { 

        private readonly BaseDbContext _context;
        public ProductRepository(BaseDbContext baseDbContext)
        {
            _context = baseDbContext;
        }

    
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
