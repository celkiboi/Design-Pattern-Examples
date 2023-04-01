using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Runner;

interface ITextLogger : ILogger
{
    char Seperator { get; set; }

    void EnterNewLine();
}
