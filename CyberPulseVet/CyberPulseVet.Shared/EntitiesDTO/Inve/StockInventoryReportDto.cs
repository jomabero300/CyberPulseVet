namespace CyberPulseVet.Shared.EntitiesDTO.Inve;

public sealed class StockInventoryReportDto
{   

    public string CompanyName { get; set; }=string.Empty;
    public string? CompanyAddress { get; set; }
    public string? CompanyPhone { get; set; }
    public string? CompanyEmail { get; set; }


    public DateTime ReportDate { get; set; }
    public int TotalProducts { get; set; }
    public int TotalUnits { get; set; }
    public decimal TotalInventoryValue { get; set; }

    public List<StockInventoryProductDto> Products { get; set; } = new();
}
public sealed class StockInventoryProductDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;

    public int TotalQuantity { get; set; }
    public decimal AveragePrice { get; set; }
    public decimal TotalValue { get; set; }

    public DateTime? NearestExpirationDate { get; set; }
}

public class EmployeeSalesResume
{
    public string EmployeeName { get; set; } = string.Empty;

    public int TotalInvoices { get; set; }

    public decimal TotalSales { get; set; }

    public decimal InitialFund { get; set; }

    public decimal FinalTotal => TotalSales + InitialFund;
}
