using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTool.Manifest
{
    internal enum TestType
    {
        None,
        Cmd,
        PowerShell,
        Python,
        File,
        Registry,
        WMI,
        WebAPI,
    }
}
