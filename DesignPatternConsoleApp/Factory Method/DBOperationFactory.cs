using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsoleApp.Factory_Method
{
    public class DBOperationFactory : DbOperationsFactoryMethod
    {
        protected override IDBOperations SaveData()
        {
            IDBOperations dBOperations = new CSVDBbperationsFactoryMethod();

            return dBOperations;
        }
    }
}
