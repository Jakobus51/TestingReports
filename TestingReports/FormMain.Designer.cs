namespace TestingReports
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbGenerateTestCafeReport = new DevExpress.XtraEditors.SimpleButton();
            this.teSelectedTestCafeFile = new DevExpress.XtraEditors.TextEdit();
            this.teSelectedUnitTestFile = new DevExpress.XtraEditors.TextEdit();
            this.sbGenerateUnitTestReport = new DevExpress.XtraEditors.SimpleButton();
            this.sbImportUnitTests = new DevExpress.XtraEditors.SimpleButton();
            this.sbImportTestCafe = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ofdUnitTests = new System.Windows.Forms.OpenFileDialog();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ofdTestCafe = new System.Windows.Forms.OpenFileDialog();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teSelectedTestCafeFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSelectedUnitTestFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbGenerateTestCafeReport);
            this.layoutControl1.Controls.Add(this.teSelectedTestCafeFile);
            this.layoutControl1.Controls.Add(this.teSelectedUnitTestFile);
            this.layoutControl1.Controls.Add(this.sbGenerateUnitTestReport);
            this.layoutControl1.Controls.Add(this.sbImportUnitTests);
            this.layoutControl1.Controls.Add(this.sbImportTestCafe);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(730, 349);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbGenerateTestCafeReport
            // 
            this.sbGenerateTestCafeReport.Location = new System.Drawing.Point(379, 144);
            this.sbGenerateTestCafeReport.Name = "sbGenerateTestCafeReport";
            this.sbGenerateTestCafeReport.Size = new System.Drawing.Size(327, 27);
            this.sbGenerateTestCafeReport.StyleController = this.layoutControl1;
            this.sbGenerateTestCafeReport.TabIndex = 6;
            this.sbGenerateTestCafeReport.Text = "Generate Test Cafe Report";
            this.sbGenerateTestCafeReport.Click += new System.EventHandler(this.sbGenerateTestCafeReport_Click);
            // 
            // teSelectedTestCafeFile
            // 
            this.teSelectedTestCafeFile.Location = new System.Drawing.Point(466, 118);
            this.teSelectedTestCafeFile.Name = "teSelectedTestCafeFile";
            this.teSelectedTestCafeFile.Size = new System.Drawing.Size(240, 22);
            this.teSelectedTestCafeFile.StyleController = this.layoutControl1;
            this.teSelectedTestCafeFile.TabIndex = 5;
            // 
            // teSelectedUnitTestFile
            // 
            this.teSelectedUnitTestFile.Location = new System.Drawing.Point(111, 118);
            this.teSelectedUnitTestFile.Name = "teSelectedUnitTestFile";
            this.teSelectedUnitTestFile.Size = new System.Drawing.Size(240, 22);
            this.teSelectedUnitTestFile.StyleController = this.layoutControl1;
            this.teSelectedUnitTestFile.TabIndex = 2;
            // 
            // sbGenerateUnitTestReport
            // 
            this.sbGenerateUnitTestReport.Location = new System.Drawing.Point(24, 144);
            this.sbGenerateUnitTestReport.Name = "sbGenerateUnitTestReport";
            this.sbGenerateUnitTestReport.Size = new System.Drawing.Size(327, 27);
            this.sbGenerateUnitTestReport.StyleController = this.layoutControl1;
            this.sbGenerateUnitTestReport.TabIndex = 3;
            this.sbGenerateUnitTestReport.Text = "Generate Unit Tests Report";
            this.sbGenerateUnitTestReport.Click += new System.EventHandler(this.sbGenerateUnitTestReport_Click);
            // 
            // sbImportUnitTests
            // 
            this.sbImportUnitTests.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.sbImportUnitTests.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbImportUnitTests.ImageOptions.SvgImage")));
            this.sbImportUnitTests.Location = new System.Drawing.Point(24, 50);
            this.sbImportUnitTests.Name = "sbImportUnitTests";
            this.sbImportUnitTests.Size = new System.Drawing.Size(327, 64);
            this.sbImportUnitTests.StyleController = this.layoutControl1;
            this.sbImportUnitTests.TabIndex = 0;
            this.sbImportUnitTests.Text = "Import Unit Tests Results";
            this.sbImportUnitTests.Click += new System.EventHandler(this.sbImportUnitTests_Click);
            // 
            // sbImportTestCafe
            // 
            this.sbImportTestCafe.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.sbImportTestCafe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbImportTestCafe.ImageOptions.SvgImage")));
            this.sbImportTestCafe.Location = new System.Drawing.Point(379, 50);
            this.sbImportTestCafe.Name = "sbImportTestCafe";
            this.sbImportTestCafe.Size = new System.Drawing.Size(327, 64);
            this.sbImportTestCafe.StyleController = this.layoutControl1;
            this.sbImportTestCafe.TabIndex = 4;
            this.sbImportTestCafe.Text = "Import Test Cafe Results";
            this.sbImportTestCafe.Click += new System.EventHandler(this.sbImportTestCafe_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(730, 349);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(355, 329);
            this.layoutControlGroup1.Text = "Unit Test Report";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbGenerateUnitTestReport;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 94);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(331, 185);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sbImportUnitTests;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(331, 68);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.teSelectedUnitTestFile;
            this.layoutControlItem3.Enabled = false;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(331, 26);
            this.layoutControlItem3.Text = "Selected file:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(75, 16);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(355, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(355, 329);
            this.layoutControlGroup2.Text = "Test Cafe Report";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sbImportTestCafe;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(331, 68);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 125);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(331, 154);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.teSelectedTestCafeFile;
            this.layoutControlItem6.Enabled = false;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(331, 26);
            this.layoutControlItem6.Text = "Selected file:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(75, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.sbGenerateTestCafeReport;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 94);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(331, 31);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // ofdUnitTests
            // 
            this.ofdUnitTests.FileName = "openFileDialog1";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.teSelectedUnitTestFile;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem5.Name = "layoutControlItem3";
            this.layoutControlItem5.Size = new System.Drawing.Size(331, 26);
            this.layoutControlItem5.Text = "Selected file:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(75, 16);
            // 
            // ofdTestCafe
            // 
            this.ofdTestCafe.FileName = "openFileDialog2";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2019 Colorful";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 349);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FormMain.IconOptions.SvgImage")));
            this.Name = "FormMain";
            this.Text = "Report Generator";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teSelectedTestCafeFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSelectedUnitTestFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton sbGenerateUnitTestReport;
        private DevExpress.XtraEditors.SimpleButton sbImportUnitTests;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit teSelectedUnitTestFile;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private OpenFileDialog ofdUnitTests;
        private DevExpress.XtraEditors.SimpleButton sbImportTestCafe;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton sbGenerateTestCafeReport;
        private DevExpress.XtraEditors.TextEdit teSelectedTestCafeFile;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private OpenFileDialog ofdTestCafe;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}