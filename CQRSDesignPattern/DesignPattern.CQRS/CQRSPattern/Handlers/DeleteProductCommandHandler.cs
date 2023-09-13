using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class DeleteProductCommandHandler
    {
        private readonly Context _context;

        public DeleteProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(DeleteProductCommand command)
        {
            var value = _context.Products.Find(command.Id);
            _context.Products.Remove(value);
            _context.SaveChanges();
        }
    }
}
