using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public MockCommanderRepo()
        {
        }

        public IEnumerable<Command> GetAppCommands()
        {
            List<Command> commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil a Egg", Line = "Boil -w -e -s", Platform = "Kitchen" },
                new Command { Id = 1, HowTo = "Cut a bread", Line = "Cut -k -b ", Platform = "Kitchen" },
                new Command { Id = 2, HowTo = "Make a cup of tea", Line = "Boil -w -c -t", Platform = "Kitchen" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil a Egg", Line = "Boil -w -e -s", Platform = "Kitchen" };
        }
    }
}