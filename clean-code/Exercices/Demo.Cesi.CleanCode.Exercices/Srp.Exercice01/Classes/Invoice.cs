public class Invoice
{
    public int Id { get; set; }
    public double Amount { get; set; }
}

public class InvoiceCalculator
{
    public double CalculateTotalWithTaxes(Invoice invoice)
    {
        return invoice.Amount * 1.2;
    }
}

public class InvoiceRepository
{
    public void SaveToFile(Invoice invoice)
    {
        // Implémentation de la sauvegarde dans un fichier
    }
}

public class InvoicePrinter
{
    public void Print(Invoice invoice)
    {
        // Implémentation de l'impression
    }
}