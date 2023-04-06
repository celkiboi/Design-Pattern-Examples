using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite;

public class Folder : IDiskEntity
{
    readonly List<IDiskEntity> contents = new();

    public string Name { get; set; }

    public Folder(string name)
    {
        Name = name;
    }

    public int SizeBytes
    {
        get
        {
            int size = 0;

            foreach (IDiskEntity item in contents)
            {
                size += item.SizeBytes;
            }

            return size;
        }
    }

    public void AddContent(IDiskEntity item)
    {
        contents.Add(item);
    }

    public void RemoveContent(IDiskEntity item) 
    {
        contents.Remove(item);
    }
}
