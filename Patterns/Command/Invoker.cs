using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    class Invoker
    {
        Command command;

        public void SetCommand(Command com)
        {
            command = com;
        }

        public void ExecuteCommand()
        {
            command?.Execute();
        }

    }
}
