namespace DesignPattern.CQRS.CQRSPattern.Commands
{
    public class DeleteProductCommand
    {
        public DeleteProductCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
