using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsoleApp
{
    public class DbOperationsFactory
    {
        public static IDBOperations DBOperations(string operationFor)
        {
            IDBOperations? dBOperations = null;             

            if (operationFor == "CSV")
            {
                dBOperations = new CSVDBbperations();
            }

            return dBOperations;
        }
    }
}
