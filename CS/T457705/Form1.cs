using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace T457705 {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }

        XtraReport1 report;
        private void simpleButton1_Click(object sender, EventArgs e) {
            report = new XtraReport1();
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }
    }
}
