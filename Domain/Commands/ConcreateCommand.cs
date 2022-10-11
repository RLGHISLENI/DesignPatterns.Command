using DesignPatterns.Domain.Interfaces;

namespace DesignPatterns.Domain.Commands
{
    public class ConcreateCommand : ICommand
    {
        private readonly int Id;
        private readonly string Name;

        public ConcreateCommand(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Execute()
        {
            Console.WriteLine($"Executing... {this.Id} - {this.Name}");
        }
    }
}
