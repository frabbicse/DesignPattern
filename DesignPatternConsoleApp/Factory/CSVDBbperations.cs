using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternConsoleApp.Factory;
using DesignPatternConsoleApp.Models;

namespace DesignPatternConsoleApp
{
    public class CSVDBbperations : IDBOperations
    {
        private readonly AppDBContext appDBContext = new AppDBContext();

        public int SaveData()
        {
            IReadFromFile readFromFile = ReadFileFactory.ReadFile("CSV");
            List<DataReadModel> dataModels = new List<DataReadModel>();
            List<DataModel> data = new List<DataModel>();
            if (readFromFile != null)
            {
                dataModels = readFromFile.ReadFile();
            }

            foreach (DataReadModel dataModel in dataModels)
            {
                data.Add(new DataModel
                {
                    AsAccountC = dataModel.AsAccountC,
                    CourseOrganizationInstitutionC = dataModel.CourseOrganizationInstitutionC,
                    EmployerC = dataModel.EmployerC,
                    OrganizationC = dataModel.OrganizationC,
                    RealStateAgencyC = dataModel.RentalAgencyC,
                    RegisteredTraingOrgTROC = dataModel.RegisteredTraingOrgTROC,
                    RentalAgencyC = dataModel.RentalAgencyC
                });
                 
            }

            appDBContext.DataModels.AddRange(data);

            int insert = appDBContext.SaveChanges();

            return 0;
        }
    }
}
