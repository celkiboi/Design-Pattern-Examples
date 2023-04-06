using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite;

public class File : IDiskEntity
{
    public string Name { get; set; }

    public int SizeBytes { get; init; }

    public File(string name, int sizeBytes)
    {
        Name = name;
        SizeBytes = sizeBytes;
    }
}
