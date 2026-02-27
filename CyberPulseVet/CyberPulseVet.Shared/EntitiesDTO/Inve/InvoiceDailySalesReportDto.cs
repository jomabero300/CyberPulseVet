using CyberPulseVet.Shared.Entities.Gene;
using CyberPulseVet.Shared.Entities.Inve;

namespace CyberPulseVet.Shared.EntitiesDTO.Inve;

public sealed class DailySalesReportDto
{
    public DateTime? SalesDate { get; set; }

    public int TotalInvoices { get; set; }
    public int TotalCustomers { get; set; }
    public decimal TotalProductsSold { get; set; }

    public decimal TotalSales { get; set; }
    public decimal TotalAmountReceived { get; set; }
    public decimal TotalChange { get; set; }

    public List<SalesByPaymentDto> SalesByPayment { get; set; } = new();
    public List<SalesByEmployeeDto> SalesByEmployee { get; set; } = new();

    
    public string? Path { get; set; }
    public Invoice? invoice { get; set; }

}
public sealed class SalesByPaymentDto
{
    public int PaymentId { get; set; }
    public string PaymentName { get; set; } = string.Empty;
    public decimal Total { get; set; }
}
public sealed class SalesByEmployeeDto
{
    public string EmployeeId { get; set; } = string.Empty;
    public string EmployeeName { get; set; } = string.Empty;
    public decimal Total { get; set; }
}