﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class FileItem : FileSystemItem
    {
        public FileItem(string name, long fileBytes) : base(name)
        {
            this.FileBytes = fileBytes;
        }

        public long FileBytes { get; }

        public override decimal GetSizeInKB()
        {
            return decimal.Divide(FileBytes, 1000);
        }
    }
}
