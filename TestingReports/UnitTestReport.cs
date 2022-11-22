using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using TestingReports.DataClasses;

namespace TestingReports
{
    public partial class UnitTestReport : DevExpress.XtraReports.UI.XtraReport
    {
        public UnitTestReport(UnitTestReportData reportData)
        {
            InitializeComponent();
            objectDataSource2.DataSource = reportData;


        }

    }
}
