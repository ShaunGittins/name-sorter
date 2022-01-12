using System;
using System.Collections.Generic;
using System.IO;

namespace name_sorter
{
    public class FileListWriter : IListWriter
    {
        private readonly string _fileName;

        public FileListWriter(string fileName)
        {
            _fileName = fileName;
        }

        public void WriteList(List<string> value)
        {
            File.WriteAllLines(Directory.GetCurrentDirectory() + _fileName, value);
        }
    }
}
