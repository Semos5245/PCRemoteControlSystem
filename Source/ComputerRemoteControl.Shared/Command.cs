using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRemoteControl.Shared
{
    public enum Command
    {
        NoCommand = 1,
        Shutdown = 2,
        Restart = 3,
        Processes = 4,
        StartProcess = 5,
        StopProcess = 6,
        ShowDirectoryContent = 7,
        Login = 8
    }
}
