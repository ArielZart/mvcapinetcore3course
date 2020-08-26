using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        IEnumerable<Command> ICommanderRepo.GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        Command ICommanderRepo.GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(c => c.Id == id);
        }

    }
}