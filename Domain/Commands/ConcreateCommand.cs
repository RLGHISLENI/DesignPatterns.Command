using DesignPatterns.Domain.Interfaces;

namespace DesignPatterns.Domain.Commands
{
    public class ConcreateCommand : ICommand
    {
        private readonly int _id;
        private readonly string _description;

        public ConcreateCommand(int id, string description)
        {
            _id = id;
            _description = description;
        }

        public void Execute()
        {
            Console.WriteLine($"Executing... {_id} - {_description}");
        }
    }
}
