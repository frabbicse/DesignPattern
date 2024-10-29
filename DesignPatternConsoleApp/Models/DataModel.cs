using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsoleApp.Models
{
    public class DataModel
    {
        [Key]
        public int Id { get; set; }
        public string? AsAccountC { get; set; }
        public string? CourseOrganizationInstitutionC { get; set; }
        public string? EmployerC { get; set; }
        public string? OrganizationC { get; set; }
        public string? RealStateAgencyC { get; set; }
        public string? RegisteredTraingOrgTROC { get; set; }
        public string? RentalAgencyC { get; set; }
    }
}
