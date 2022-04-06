namespace DrillDownChart {
    public class ChartDrillDownDataProvider : IChartDrillDownDataProvider {
        public List<SaleItem> Generate() {
            return SaleItem.GetTotalIncome();
        }
    }
    public interface IChartDrillDownDataProvider {
        public List<SaleItem> Generate();
    }
}
