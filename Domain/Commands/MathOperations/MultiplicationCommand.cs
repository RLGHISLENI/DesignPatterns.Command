using DesignPatterns.Domain.Interfaces;

namespace DesignPatterns.Domain.Commands.MathOperations
{
    public class MultiplicationCommand : ICommand
    {
        private readonly decimal _value1;
        private readonly decimal _value2;

        public MultiplicationCommand(decimal value1, decimal value2)
        {
            _value1 = value1;
            _value2 = value2;
        }

        public void Execute()
        {
            var Multiplication = _value1 * _value2;
            Console.WriteLine($"Multiplication ({_value1} * {_value2}) = {Math.Round(Multiplication, 2)}");
        }
    }
}
