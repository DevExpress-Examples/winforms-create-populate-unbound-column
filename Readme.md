# How to create and populate an unbound column


<p>GridView does not cache values of an unbound column, because it is impossible to determine when the cache should be cleared automatically. GridView just displays values provided by the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.CustomUnboundColumnData.event">CustomUnboundColumnData</a> event. So, to display a specific value in a cell, you need to pass a corresponding value to the e<strong>.Value</strong> parameter based on a processed column and row. What you return as the e<strong>.Value</strong> parameter is what is displayed in GridView. Each time a cell needs to be updated, the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.CustomUnboundColumnData.event">CustomUnboundColumnData</a> event is called.</p>
<p>This example demonstrates how a simple caching mechanism can be implemented. In this project, you can perform all supported operations with GridView, such as sorting/deleting/adding records, and the unbound column will display proper values. This is because values of the ID column are used as key values. This column is read-only and contains only unique values. So, rows can be always identified.<br><br>You can also use the  <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Columns.GridColumn.UnboundExpression.property">GridColumn.UnboundExpression</a> property to specify and unbound expression. Please refer to the <a href="https://documentation.devexpress.com/WindowsForms/1477/Controls-and-Libraries/Data-Grid/Views/Grid-View/Unbound-Columns">Unbound Columns</a> help article for additional information.</p>

<br/>


