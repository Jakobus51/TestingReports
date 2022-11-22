using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace TestingReports.DataClasses
{
    public class UnitTestReportData
    {
        /// <summary>
        /// The name that will be displayed on top of the report
        /// </summary>
        public string? ProductName { get; set; }

        /// <summary>
        /// The version of the product
        /// </summary>
        public string? ProductVersion { get; set; }

        /// <summary>
        /// The validation package version
        /// </summary>
        public string? ValidationPackageVersion { get; set; }

        /// <summary>
        /// Extra information you want to provide on the first page of your report
        /// </summary>
        public string? ReportDescription { get; set; }

        /// <summary>
        /// Time and date the unit test was executed
        /// </summary>
        public DateTime DateTimeExecuted { get; set; }

        /// <summary>
        /// Results and information of each invidual unit test
        /// </summary>
        public List<UnitTestResult> UnitTestResults { get; set; }

        public UnitTestReportData()
        {
            UnitTestResults = new();
        }

    }
}
