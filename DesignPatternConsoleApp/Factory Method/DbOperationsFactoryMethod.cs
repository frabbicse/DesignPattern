using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsoleApp
{
    public abstract class DbOperationsFactoryMethod
    {
        protected abstract IDBOperations SaveData();
        public IDBOperations DBOperations()
        {
            IDBOperations? dBOperations = this.SaveData();             

            
            return dBOperations;
        }
    }
}
