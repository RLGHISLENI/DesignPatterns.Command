using DesignPatterns.Domain.Entities;
using DesignPatterns.Domain.Interfaces;

namespace DesignPatterns.Application
{
    public class Receiver : IReceiver<ICommand, IState>
    {
        public IState Action(ICommand command)
        {
            try
            {
                command.Execute();
                return new State(200, "Command executed successfully!");
            }
            catch (Exception ex)
            {
                return new State(500, ex.Message);
            }
        }
    }
}
