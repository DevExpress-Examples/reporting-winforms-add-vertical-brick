<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128598234/16.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T457705)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/T457705/Form1.cs) (VB: [Form1.vb](./VB/T457705/Form1.vb))
* [Program.cs](./CS/T457705/Program.cs) (VB: [Program.vb](./VB/T457705/Program.vb))
* [XtraReport1.cs](./CS/T457705/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/T457705/XtraReport1.vb))
<!-- default file list end -->
# How to add a brick with vertical text to the margin of each report page


<p>This example illustrates how to draw a custom vertical text into the left page margin. To accomplish this task, the <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraPrintingLabelBricktopic">LabelBrick</a> element is added to the page's <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingPage_InnerBrickstopic">inner bricks</a> collection in the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_AfterPrinttopic">XtraReport.AfterPrint</a> event handler.</p>

<br/>


