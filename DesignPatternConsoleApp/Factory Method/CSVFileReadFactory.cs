using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsoleApp.Factory_Method
{
    public class CSVFileReadFactory : ReadFileFactoryMethod
    {
        protected override IReadFromFile ReadFromFile()
        {
            IReadFromFile readFromFile = new ReadCSVFile();

            return readFromFile;
        }
    }
}
