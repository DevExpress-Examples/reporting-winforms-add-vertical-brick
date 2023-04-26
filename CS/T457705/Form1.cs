using System;
using DevExpress.XtraReports.UI;

namespace T457705 {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            var report = new XtraReport1();
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowRibbonPreviewDialog();
        }
    }
}
