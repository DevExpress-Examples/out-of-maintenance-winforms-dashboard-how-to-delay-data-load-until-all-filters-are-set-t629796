# WinForms Dashboard - How to delay data load until all filters are set


This example demonstrates how to load data in the Dashboard designer on demand, that is when all required filters are set. <br>Currently, the designer reloads data after any changes in filter elements. This behavior hinders the performance in case of large amounts of data.<br>The suggested approach allows you to select filter values without actual data loaded and subsequently click the <strong>Show Data</strong> button in the dashboard title to load and display filtered data.<br>The <strong>Show Data</strong> button is created by handling the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.CustomizeDashboardTitle">DashboardDesigner.CustomizeDashboardTitle</a> event.<br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/winforms-dashboard-how-to-delay-data-load-until-all-filters-are-set-t629796/18.1.3+/media/358bba5b-a2f8-41f3-a3ca-71ac7c9e894e.png"><br><br>See also the <a href="https://www.devexpress.com/Support/Center/p/T630210">WinForms Dashboard - How to customize the dashboard title and dashboard item captions</a> example.

<br/>


