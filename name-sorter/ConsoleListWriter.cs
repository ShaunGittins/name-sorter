using System;
using System.Collections.Generic;

namespace name_sorter
{
    public class ConsoleListWriter : IListWriter
    {
        public void WriteList(List<string> value)
        {
            foreach (string item in value)
            {
                Console.WriteLine(item);
            }
        }
    }
}
