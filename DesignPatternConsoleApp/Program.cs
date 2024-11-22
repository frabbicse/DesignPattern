using AbstractFactoryDP;
using BuildderDP;
using DesignPatternConsoleApp;
using DesignPatternConsoleApp.Factory_Method;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //IDBOperations dbOperations = DbOperationsFactory.DBOperations("CSV");
        //IDBOperations dbOperations = new DBOperationFactory().DBOperations();

        //if (dbOperations != null)
        //{
        //    dbOperations.SaveData();
        //}

        /// abstract factory 
        //IFileSaveFactory fileSaveFactory = new FileSaveFactory();
        //IFileSave fileSave = fileSaveFactory.SaveFile();
        //int i = fileSave.Save();
        //Console.WriteLine(i);

        //var electricCarFactory = new ElectricCarFactory();
        //var electricCarPlant = new VehicleManufacturingPlant(electricCarFactory);
        //electricCarPlant.DescribeVehicle();
        //var gasTruckFactory = new GasTruckFactory();
        //var gasTruckPlant = new VehicleManufacturingPlant(gasTruckFactory);
        //gasTruckPlant.DescribeVehicle();


        // builder 

        PDFReport pDFReport = new PDFReport();

        ReportDirector director = new ReportDirector(); 

        Report report = director.MakeReport(pDFReport);
        report.DisplayReport();
        Console.WriteLine("--------------------");

        ExcellReport excellReport = new ExcellReport(); 
        report = director.MakeReport(excellReport);

        report.DisplayReport(); 

    }
}