<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134061840/18.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T629796)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
*Files to look at*:

* [DesignerForm1.cs](./CS/CustomShowDataExample/DesignerForm1.cs) (VB: [DesignerForm1.vb](./VB/CustomShowDataExample/DesignerForm1.vb))

# Dashboard for WinForms - Delay Data Load Until All Filters are Set

This example demonstrates how to create a custom button in the dashboard title to load data on demand.

Currently, the designer reloads data after any changes in filter elements. This behavior hinders the performance in case of large amounts of data.

The suggested approach allows you to select filter values without actual data loaded and subsequently click the **Show Data** button in the dashboard title to load and display filtered data.

The **Show Data** button is created in the [DashboardDesigner.CustomizeDashboardTitle](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.CustomizeDashboardTitle) event handler.

![](/images/screenshot.png)

## Documentation

- [Title and Item Captions](https://docs.devexpress.com/Dashboard/400075)
- [Dashboard Parameters](https://docs.devexpress.com/Dashboard/116918)
- [Pass a Dashboard Parameter to a Filter String](https://docs.devexpress.com/Dashboard/117087)

## More Examples

- [WinForms Dashboard - How to customize the dashboard title and dashboard item captions](https://github.com/DevExpress-Examples/winforms-dashboard-how-to-customize-the-dashboard-title-and-dashboard-item-captions-t630210)
