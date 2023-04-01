using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Runner;

class ConsoleLogger : ITextLogger
{
    public ConsoleLogger(char seperator)
    {
        Seperator = seperator;
    }

    public char Seperator { get; set; }

    public void Log<T>(T data)
    {
        Console.Write(data);
    }

    public void LogCollection<T>(IEnumerable<T> data)
    {
        foreach (T item in data)
        {
            Console.Write(item);
            Console.Write(Seperator);
        }
    }

    public void EnterNewLine()
    {
        Console.Write('\n');
    }
}
