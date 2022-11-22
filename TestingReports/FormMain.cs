using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TestingReports.DataClasses;
using System.Xml;
using TestingReports;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;

namespace TestingReports
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public UnitTestReportData? unitTestReportData;
        public string jsonReportString;

        public FormMain()
        {
            InitializeComponent();
        }

        private void sbImportUnitTests_Click(object sender, EventArgs e)
        {
            ofdUnitTests.DefaultExt = ".xml";
            ofdUnitTests.Filter = "(*.xml)|*.xml";

            if (ofdUnitTests.ShowDialog() == DialogResult.OK)
            {
                unitTestReportData = ReadUnitTestResults(ofdUnitTests.FileName);
                if (unitTestReportData != null)
                {
                    teSelectedUnitTestFile.Text = ofdUnitTests.SafeFileName;
                }
                else
                {
                    XtraMessageBox.Show("Could not open the Unit Test Result", "Error");
                }
            }
        }

        private void sbImportTestCafe_Click(object sender, EventArgs e)
        {
            ofdTestCafe.DefaultExt = ".JSON";
            ofdTestCafe.Filter = "(*.JSON)|*.JSON";

            if (ofdTestCafe.ShowDialog() == DialogResult.OK)
            {
                jsonReportString = ReadTestCafeReport(ofdTestCafe.FileName);

                if (jsonReportString != string.Empty)
                {
                    teSelectedTestCafeFile.Text = ofdTestCafe.SafeFileName;
                }
                else
                {
                    XtraMessageBox.Show("Could not open the Test Cafe Results", "Error");
                }
            }
        }

        private void sbGenerateUnitTestReport_Click(object sender, EventArgs e)
        {
            UnitTestReport UnitTestReport = new UnitTestReport(unitTestReportData);
            UnitTestReport.ShowPreview();
        }

        private void sbGenerateTestCafeReport_Click(object sender, EventArgs e)
        {            
            TestCafeReport TestCafeReport = new TestCafeReport(jsonReportString);
            TestCafeReport.ShowPreview();
            
        }

        #region Reading result

        /// <summary>
        /// Reads the xml file of the unit test results if unable to read return an empty UnitTestReportData datastructure
        /// </summary>
        public UnitTestReportData? ReadUnitTestResults(string saveLocation)
        {   
            string content = string.Empty;
            using (StreamReader myFile = new StreamReader(saveLocation))
            {
                content = myFile.ReadToEnd();
                myFile.Close();
            }

            if (content.Equals(""))
                return new UnitTestReportData();
            else
                return Deserialize(typeof(UnitTestReportData), content) as UnitTestReportData;
        }
        

        public static object? Deserialize(Type typeObj, string xmlString)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeObj);
                
                var result = serializer.Deserialize(new StringReader(xmlString));
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        /// <summary>
        /// Reads the JSON file if unable to read return an empty string
        /// </summary>
        public string ReadTestCafeReport(string fileName)
        {
            string json = string.Empty;
            using (StreamReader myFile = new StreamReader(fileName))
            {
                json = myFile.ReadToEnd();               
            }

            return json;
        }


        #endregion

    }
}