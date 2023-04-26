Imports DevExpress.XtraReports.UI

Namespace T457705
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim report As New XtraReport1()
			Dim tool As New ReportPrintTool(report)
			tool.ShowRibbonPreviewDialog()
		End Sub
	End Class
End Namespace
