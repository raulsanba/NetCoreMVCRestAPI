using CoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Data
{
    public class MockCommanderRepo : ICommanderRepo //hay que implementarla con "ctrl + . "
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "pan and kettle" },
                new Command { Id = 1, HowTo = "Cut bread", Line = "knife", Platform = "chopping board" },
                new Command { Id = 2, HowTo = "cup of coffe", Line = "warm water", Platform = "cup" }

            };
            return commands;

        }


        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "pan and kettle" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
    
}
