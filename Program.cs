using DesignPatterns.Application;
using DesignPatterns.Domain.Commands;
using DesignPatterns.Domain.Commands.MathOperations;
using DesignPatterns.Domain.Entities;

namespace DesignPatterns.Command
{
    internal class Program
    {
        static void Main()
        {
            var command = new ConcreateCommand(0, "Running the direct command...");
            command.Execute();
            Console.WriteLine();

            var receiver = new Receiver();
            var firstCommand = (State)receiver.Action(new ConcreateCommand(1, "First command"));
            Console.WriteLine($"State: {firstCommand.StatusCode}-{firstCommand.Message}");
            Console.WriteLine();

            var secondCommand = (State)new Receiver().Action(new ConcreateCommand(2, "Second command"));
            Console.WriteLine($"State: {secondCommand.StatusCode}-{secondCommand.Message}");
            Console.WriteLine();

            var additionCommand = (State)receiver.Action(new AdditionCommand(10, 20));
            Console.WriteLine($"State: {additionCommand.StatusCode}-{additionCommand.Message}");
            Console.WriteLine();

            var subtractionCommand = (State)receiver.Action(new SubtractionCommand(45, 39));
            Console.WriteLine($"State: {subtractionCommand.StatusCode}-{subtractionCommand.Message}");
            Console.WriteLine();

            var multiplicationCommand = (State)receiver.Action(new MultiplicationCommand(42, 17));
            Console.WriteLine($"State: {multiplicationCommand.StatusCode}-{multiplicationCommand.Message}");
            Console.WriteLine();

            var divisionCommand = (State)receiver.Action(new DivisionCommand(7, 9));
            Console.WriteLine($"State: {divisionCommand.StatusCode}-{divisionCommand.Message}");
            Console.WriteLine();

            var divisionByZeroCommand = (State)receiver.Action(new DivisionCommand(2022, 0));
            Console.WriteLine($"State: {divisionByZeroCommand.StatusCode}-{divisionByZeroCommand.Message}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}