namespace Ocp.Exercice01.Classes;

public class InvoiceService : IInvoiceService
{
    private readonly IInvoiceService _invoiceService;

    public InvoiceService(IInvoiceService invoiceService)
    {
        _invoiceService = invoiceService;
    }

    public void PrintInvoice()
    {
     _invoiceService.PrintInvoice();   
    }
}