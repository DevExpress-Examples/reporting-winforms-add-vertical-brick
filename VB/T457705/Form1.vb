Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace T457705
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private report As XtraReport1
		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			report = New XtraReport1()
			Dim tool As New ReportPrintTool(report)
			tool.ShowPreview()
		End Sub
	End Class
End Namespace
