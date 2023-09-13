using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var value = _context.Products.Select(x => new GetProductQueryResult
            {
                ID = x.ID,
                Price = x.Price,
                ProductName = x.Name,
                Stock = x.Stock
            }).ToList();
            return value;
        }
    }
}
