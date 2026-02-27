using CyberPulseVet.Shared.Entities.Inve;

namespace CyberPulseVet.Shared.EntitiesDTO.Inve;

public class DashboardSummaryDto
{
    // ===== HOY =====
    public decimal SalesToday { get; set; }
    public decimal SalesYesterday { get; set; }
    public decimal SalesPercentageVsYesterday { get; set; }

    public int TransactionsToday { get; set; }
    public int TransactionsYesterday { get; set; }
    public int TransactionsDifference { get; set; }
    public decimal TransactionsPercentageVsYesterday { get; set; }

    // ===== MES =====
    public decimal SalesCurrentMonth { get; set; }
    public decimal SalesPreviousMonth { get; set; }
    public decimal SalesPercentageVsPreviousMonth { get; set; }

    public int LowStockProducts { get; set; }

    // ===== 5 PRODUCTOS MAS VENDIDOS HOY =====
    public ICollection<TopProductDto>? ProductDto { get; set; }

}

public class TopProductDto
{
    public string ProductName { get; set; } = string.Empty;
    public decimal QuantitySold { get; set; }
}