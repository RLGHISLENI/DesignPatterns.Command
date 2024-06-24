using DesignPatterns.Domain.Interfaces;

namespace DesignPatterns.Command.Application
{
    public class Invoker
    {
        private readonly ICommand _additionCommand;
        private readonly ICommand _divisionCommand;
        private readonly ICommand _multiplicationCommand;
        private readonly ICommand _subtractionCommand;

        public Invoker(
            ICommand additionCommand, 
            ICommand divisionCommand, 
            ICommand multiplicationCommand, 
            ICommand subtractionCommand)
        {
            _additionCommand = additionCommand;
            _divisionCommand = divisionCommand;
            _multiplicationCommand = multiplicationCommand;
            _subtractionCommand = subtractionCommand;
        }

        public void Addition()
        {
            _additionCommand.Execute();
        }

        public void Dvision()
        {
            _divisionCommand.Execute();
        }

        public void Multiplication()
        {
            _multiplicationCommand.Execute();
        }
        
        public void Subtraction()
        {
            _subtractionCommand.Execute();
        }
    }
}
