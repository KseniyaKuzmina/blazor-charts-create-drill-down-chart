<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/478478126/22.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1081109)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Chart for Blazor - Create a Drill-Down Chart

You can create drill-down charts to visualize hierarchical data and allow users to explore its details. In this example, yearly product sales are distributed between company branches and product categories. Click bar series points, area series, and breadcrumb items to navigate detail levels.

![Drill-down chart](images/drill-down.png)

The example uses a [template](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCommonSeries-4.SeriesTemplate) to create series. The template is configured to apply individual settings to series types. Data fields that correspond to arguments and series names are passed as [expressions](https://docs.microsoft.com/en-us/dotnet/api/system.linq.expressions.expression?view=net-6.0) to obtain data for a specific detail level.

The example handles the [SeriesClick](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.SeriesClick) and [onClick](https://www.w3schools.com/jsref/event_onclick.asp) events to respond to element clicks and switch between data detail levels. Depending on the level, the chart loads and displays corresponding data.

## Files to Look At

- [Index.razor](CS/DrillDownChart/Pages/Index.razor)

## Documentation

- [DxChart](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-charts-create-drill-down-chart&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-charts-create-drill-down-chart&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
