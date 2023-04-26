using System;
using System.Drawing;
using DevExpress.XtraPrinting;

namespace T457705 {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void XtraReport1_AfterPrint(object sender, EventArgs e) {
            string text = "Developer Express Inc.";
            Font font = new Font("Arial", 20f);
            SizeF size = this.PrintingSystem.Graph.MeasureString(text, font);
            size.Height = size.Height + 100;
            size.Width = size.Width + 50;
            foreach (Page page in this.Pages) {
                LabelBrick labelBrick = CreateLabel(page, font, size, text);
                page.AddBrick(labelBrick);
            }
        }

        LabelBrick CreateLabel(Page page, Font font, SizeF size, string text) {
            LabelBrick labelBrick = new LabelBrick() { 
                Angle = 90, 
                Font = font, 
                Text = text,
                VertAlignment = DevExpress.Utils.VertAlignment.Center
             };
            PointF brickLocation = new PointF(page.MarginsF.Left / 5, page.Size.Height / 2);
            SizeF brickSize = new SizeF(size.Height, size.Width);
            labelBrick.Initialize(this.PrintingSystem, new RectangleF(brickLocation, brickSize));
            return labelBrick;
        }

    }
}
