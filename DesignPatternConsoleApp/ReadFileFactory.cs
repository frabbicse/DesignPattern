using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsoleApp
{
    public class ReadFileFactory
    {
        public static IReadFromFile ReadFile(string fileType)
        {
            IReadFromFile? readFromFile = null;

            if (fileType == "CSV")
            {
                readFromFile = new ReadCSVFile();
            }

            return readFromFile;
        }
    }
}
