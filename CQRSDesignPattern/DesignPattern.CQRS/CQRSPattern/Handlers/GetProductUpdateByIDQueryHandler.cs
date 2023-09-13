using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductByIDQuery query)
        {
            var value = _context.Products.Find(query.Id);
            return new GetProductUpdateQueryResult
            {
                Description = value.Description,
                Name = value.Name,
                Price = value.Price,
                Stock = value.Stock,
                ID = value.ID
            };
        }
    }
}
