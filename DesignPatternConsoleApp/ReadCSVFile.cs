using CsvHelper;
using CsvHelper.Configuration;
using DesignPatternConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsoleApp
{
    public class ReadCSVFile : IReadFromFile
    {
        public List<DataReadModel> ReadFile()
        {
            List<DataReadModel> list = new List<DataReadModel>();

            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
            using (var reader = new StreamReader("H:/Remnant/DesignPattern/demo_salesforce_data.csv"))

            using (var csv = new CsvReader(reader, configuration))
            { 
                list = new List<DataReadModel>(csv.GetRecords<DataReadModel>());
            }


            return list;
        }


    }
}
