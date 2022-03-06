using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class FileSystemBuilder
    {
        private DirectoryItem currentDirectory;

        public FileSystemBuilder(string rootDirectory)
        {
            Root = new DirectoryItem(rootDirectory);
            currentDirectory = Root;
        }

        public DirectoryItem Root { get; }

        public DirectoryItem AddDirectory(string name)
        {
            var dir = new DirectoryItem(name);
            currentDirectory.Add(dir);
            currentDirectory = dir;
            return dir;
        }

        public FileItem AddFile(string name, long fileBytes)
        {
            var file = new FileItem(name, fileBytes);
            currentDirectory.Add(file);
            return file;
        }

        public DirectoryItem SetCurrentDirectory(string directoryName)
        {
            var dirStack = new Stack<DirectoryItem>();
            dirStack.Push(this.Root);
            while(dirStack.Count > 0)
            {
                var current = dirStack.Pop();
                if(current.Name == directoryName)
                {
                    currentDirectory = current;
                    return currentDirectory;
                }
                foreach(var item in currentDirectory.Items.OfType<DirectoryItem>())
                {
                    dirStack.Push(item);
                }
            }
            throw new InvalidOperationException($"Directory name '{directoryName}' not found!");
        }
    }
}
