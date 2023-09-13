using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIDQueryResult Handle(GetProductByIDQuery query)
        {
            var value = _context.Set<Product>().Find(query.Id);
            return new GetProductByIDQueryResult
            {
                Name = value.Name,
                Price = value.Price,
                ID = value.ID,
                Stock = value.Stock
            };
        }
    }
}
