<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128626798/11.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3354)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Data Grid for Windows Forms - How to create and populate an unbound column

This example creates an [unbound column](https://docs.devexpress.com/WindowsForms/1477/controls-and-libraries/data-grid/unbound-columns) in a [Grid Control](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl). The code handles the [ColumnView.CustomUnboundColumnData](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.CustomUnboundColumnData) event to populate the unbound column with data.

A user can enter values in the unbound column. These values are not cached by the Grid Control. The example demonstrates how to manually implement a value cache.

<!-- default file list -->
## Files to Look At

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
<!-- default file list end -->


## Documentation
- [ColumnView.CustomUnboundColumnData](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.CustomUnboundColumnData)
- [Unbound Columns](https://docs.devexpress.com/WindowsForms/1477/controls-and-libraries/data-grid/unbound-columns)

## See Also

- [DevExpress WinForms Cheat Sheet - Show Values from External Sources. Calculated Field Values. Unbound Mode](https://go.devexpress.com/CheatSheets_WinForms_Examples_T906256.aspx)
- [DevExpress WinForms Troubleshooting - Grid Control](https://go.devexpress.com/CheatSheets_WinForms_Examples_T934742.aspx)
