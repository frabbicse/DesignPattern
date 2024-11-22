using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildderDP
{
    public class ExcellReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "Excell Content Section";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Excell Footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Excell Header";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "Excell";
        }
    }
}
