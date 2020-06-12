using CoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Data
{
    public interface ICommanderRepo//interfaz de metodos a implementar por otras clases. En este caso se adapta a CRUD operations. No implementamos nada, solo definimos.
    {
        bool SaveChanges();
        
        //give a list of all commands
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}
