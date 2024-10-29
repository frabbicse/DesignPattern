using DesignPatternConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        IDBOperations dbOperations = DbOperationsFactory.DBOperations("CSV");

        if (dbOperations != null)
        {
            dbOperations.SaveData();
        }
    }
}