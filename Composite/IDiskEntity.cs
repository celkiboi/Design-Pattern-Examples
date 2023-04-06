using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite;

public interface IDiskEntity
{
    public string Name { get; set; }
    public int SizeBytes { get; }
}
