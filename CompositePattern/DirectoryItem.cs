using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class DirectoryItem : FileSystemItem
    {
        public DirectoryItem(string name) : base(name)
        {
        }

        // using read-only property & auto property initializer langugage feature
        public List<FileSystemItem> Items { get; } = new List<FileSystemItem>();

        public void Add(FileSystemItem component)
        {
            Items.Add(component);
        }

        public void Remove(FileSystemItem component)
        {
            Items.Remove(component);
        }

        public override decimal GetSizeInKB()
        {
            return Items.Sum(x => x.GetSizeInKB());
        }
    }
}
