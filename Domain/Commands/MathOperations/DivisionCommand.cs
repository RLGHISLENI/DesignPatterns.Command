using DesignPatterns.Domain.Interfaces;

namespace DesignPatterns.Domain.Commands.MathOperations
{
    public class DivisionCommand : ICommand
    {
        private readonly decimal _value1;
        private readonly decimal _value2;

        public DivisionCommand(decimal value1, decimal value2)
        {
            _value1 = value1;
            _value2 = value2;
        }

        public void Execute()
        {
            var Division = _value1 / _value2;
            Console.WriteLine($"Division ({_value1} / {_value2}) = {Math.Round(Division, 2)}");
        }
    }
}
