using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsoleApp
{
    public abstract class ReadFileFactoryMethod
    {
        protected abstract IReadFromFile ReadFromFile();
        public IReadFromFile ReadFile()
        {
            IReadFromFile? readFromFile = this.ReadFromFile();             

            return readFromFile;
        }

    }
}
