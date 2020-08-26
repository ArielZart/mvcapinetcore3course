using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepoMock
    {

        IEnumerable<Command> GetAllCommandsMock();

        Command GetCommandByIdMock(int id);
    }
}