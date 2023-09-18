using System.Data.SqlTypes;

namespace DesignPattern.ObserverDesignPattern.DAL
{
    public class WelcomeMessage
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Content { get; set; }
    }
}
