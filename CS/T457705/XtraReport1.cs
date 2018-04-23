using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;

namespace T457705 {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void XtraReport1_AfterPrint(object sender, EventArgs e) {
            string text = "Developer Express Inc.";
            Font font = new Font("Arial", 20f, FontStyle.Bold);
            SizeF size = this.PrintingSystem.Graph.MeasureString(text, font);
            foreach(Page page in this.Pages) {
                LabelBrick labelBrick = CreateLabel(page, font, size, text);
                page.InnerBricks.Add(labelBrick);
            }
        }

        LabelBrick CreateLabel(Page page, Font font, SizeF size, string text) {
            LabelBrick labelBrick = new LabelBrick() { Angle = 90, Font = font, Text = text };
            PointF brickLocation = new PointF(page.MarginsF.Left / 2, page.Size.Height / 2);
            SizeF brickSize = new SizeF(size.Height, size.Width);
            labelBrick.Initialize(this.PrintingSystem, new RectangleF(brickLocation, brickSize));
            return labelBrick;
        }
    }
}
