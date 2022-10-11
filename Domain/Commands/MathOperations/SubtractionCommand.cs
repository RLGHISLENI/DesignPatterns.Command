using DesignPatterns.Domain.Interfaces;

namespace DesignPatterns.Domain.Commands.MathOperations
{
    public class SubtractionCommand : ICommand
    {
        private readonly decimal _value1;
        private readonly decimal _value2;

        public SubtractionCommand(decimal value1, decimal value2)
        {
            _value1 = value1;
            _value2 = value2;
        }

        public void Execute()
        {
            var Subtraction = _value1 - _value2;
            Console.WriteLine($"Subtraction ({_value1} - {_value2}) = {Math.Round(Subtraction, 2)}");
        }
    }
}
