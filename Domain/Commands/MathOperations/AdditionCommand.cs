using DesignPatterns.Domain.Interfaces;

namespace DesignPatterns.Domain.Commands.MathOperations
{
    public class AdditionCommand : ICommand
    {
        private readonly decimal _value1;
        private readonly decimal _value2;

        public AdditionCommand(decimal value1, decimal value2)
        {
            _value1 = value1;
            _value2 = value2;
        }

        public void Execute()
        {
            var addition = _value1 + _value2;
            Console.WriteLine($"Addition ({_value1} + {_value2}) = {Math.Round(addition, 2)}");
        }
    }
}
