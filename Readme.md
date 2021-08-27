<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128626798/11.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3354)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to create and populate an unbound column


<p>GridView does not cache values of an unbound column, because it is impossible to determine when the cache should be cleared automatically. GridView just displays values provided by the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.CustomUnboundColumnData.event">CustomUnboundColumnData</a> event. So, to display a specific value in a cell, you need to pass a corresponding value to the e<strong>.Value</strong> parameter based on a processed column and row. What you return as the e<strong>.Value</strong> parameter is what is displayed in GridView. Each time a cell needs to be updated, the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.CustomUnboundColumnData.event">CustomUnboundColumnData</a> event is called.</p>
<p>This example demonstrates how a simple caching mechanism can be implemented. In this project, you can perform all supported operations with GridView, such as sorting/deleting/adding records, and the unbound column will display proper values. This is because values of the ID column are used as key values. This column is read-only and contains only unique values. So, rows can be always identified.<br><br>You can also use the  <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Columns.GridColumn.UnboundExpression.property">GridColumn.UnboundExpression</a> property to specify and unbound expression. Please refer to the <a href="https://documentation.devexpress.com/WindowsForms/1477/Controls-and-Libraries/Data-Grid/Views/Grid-View/Unbound-Columns">Unbound Columns</a> help article for additional information.</p>

<b>See also:</b>

[DevExpress WinForms Cheat Sheet - Show Values from External Sources. Calculated Field Values. Unbound Mode](https://go.devexpress.com/CheatSheets_WinForms_Examples_T906256.aspx)

[DevExpress WinForms Troubleshooting - Grid Control](https://go.devexpress.com/CheatSheets_WinForms_Examples_T934742.aspx)

<br/>


