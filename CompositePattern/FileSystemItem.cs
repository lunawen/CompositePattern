using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class FileSystemItem
    {
        public FileSystemItem(string name)
        {
            this.Name = name;
        }

        public object Name { get; }

        public abstract decimal GetSizeInKB();
    }
}
