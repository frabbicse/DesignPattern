using DesignPatternConsoleApp;
using DesignPatternConsoleApp.Factory_Method;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //IDBOperations dbOperations = DbOperationsFactory.DBOperations("CSV");
        IDBOperations dbOperations = new DBOperationFactory().DBOperations();

        if (dbOperations != null)
        {
            dbOperations.SaveData();
        }
    }
}