using DevExpress.DataAccess.Json;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace TestingReports
{
    public partial class TestCafeReport : DevExpress.XtraReports.UI.XtraReport
    {
        

        public TestCafeReport(string jsonString)
        {
            this.DataSource = new JsonDataSource() { JsonSource = new CustomJsonSource(jsonString) };

            InitializeComponent();

            //jsonDataSource3.JsonSource = new CustomJsonSource(jsonString);

        }
    }
}
