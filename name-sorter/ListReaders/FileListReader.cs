using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace name_sorter
{
    public class FileListReader : IListReader
    {
        private readonly string _fileName;

        public FileListReader(string fileName)
        {
            _fileName = fileName;
        }

        public List<string> ReadList()
        {
            string entirePath = Directory.GetCurrentDirectory() + "\\" + _fileName;

            if (File.Exists(entirePath))
            {
                return File.ReadAllLines(entirePath).ToList();
            }
            else
            {
                Console.WriteLine("File not found: " + entirePath);
                return new List<string>();
            }
        }
    }
}
