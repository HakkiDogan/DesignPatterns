﻿using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var value = _context.Products.Find(command.ProductID);
            if (value != null)
            {
                value.Name = command.Name;
                value.Price = command.Price;
                value.Stock = command.Stock;
                value.Description = command.Description;
                _context.SaveChanges();
            }
            
        }
    }
}
