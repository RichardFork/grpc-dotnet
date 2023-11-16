using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace FirstTutorial;
public class MyLogger 
{
    public MyLogger()
    {
        Debug.WriteLine("inject gretterservice to my logger");
    }
}
