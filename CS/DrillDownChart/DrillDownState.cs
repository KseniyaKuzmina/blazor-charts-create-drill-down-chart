using DevExpress.Blazor;
using System.Linq.Expressions;

namespace DrillDownChart {
    public class DrillDownState {
        public string Name { get; }
        public IEnumerable<SaleItem> Data { get; }
        public Expression<Func<SaleItem, string>> GetSeriesExpression { get; }
        public Expression<Func<SaleItem, object>> GetArgumentExpression { get; }
        public ChartAxisZoomAndPanMode ZoomAndPanMode { get; }
        public bool Rotated { get; }
        public ChartSeriesType SeriesType { get; }
        public ChartAxisDataType AxisDataType { get; }

        public DrillDownState(string name,
                     IEnumerable<SaleItem> data,
                     Expression<Func<SaleItem, string>> getSeriesExpression,
                     Expression<Func<SaleItem, object>> getArgumentExpression,
                     bool rotated,
                     ChartAxisZoomAndPanMode zoomAndPanMode,
                     ChartSeriesType seriesType,
                      ChartAxisDataType axisDataType) {
            (Name, Data, GetSeriesExpression, GetArgumentExpression, Rotated, ZoomAndPanMode, SeriesType, AxisDataType) =
            (name, data, getSeriesExpression, getArgumentExpression, rotated, zoomAndPanMode, seriesType, axisDataType);
        }

    }
}
