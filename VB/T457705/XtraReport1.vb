Imports DevExpress.Utils
Imports DevExpress.XtraPrinting
Imports Devexpress.Drawing
Namespace T457705
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub XtraReport1_AfterPrint(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.AfterPrint
            Dim brickText As String = "Developer Express Inc."
            Dim brickFont As New DXFont("Arial", 20.0F)
            Dim brickSize As SizeF = Me.PrintingSystem.Graph.MeasureString(brickText, brickFont)
            brickSize.Height = brickSize.Height + 100
            brickSize.Width = brickSize.Width + 50
            For Each page As Page In Me.Pages
                Dim labelBrick As LabelBrick = CreateLabel(page, brickFont, brickSize, brickText)
                page.InnerBricks.Add(labelBrick)
            Next page
        End Sub
        Private Function CreateLabel(ByVal page As Page, ByVal font As DXFont, ByVal size As SizeF, ByVal text As String) As LabelBrick
            Dim labelBrick As New LabelBrick() With {
                .Angle = 90,
                .Font = font,
                .Text = text,
                .VertAlignment = VertAlignment.Center}
            Dim brickLocation As New PointF(page.MarginsF.Left / 5, page.Size.Height / 2)
            Dim brickSize As New SizeF(size.Height, size.Width)
            labelBrick.Initialize(Me.PrintingSystem, New RectangleF(brickLocation, brickSize))
            Return labelBrick
        End Function
    End Class
End Namespace
