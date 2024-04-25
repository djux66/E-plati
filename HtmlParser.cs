using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using System.Globalization;

namespace Eplati;

public class HtmlParser
{
    private readonly IBrowsingContext _browser;

    public HtmlParser(IBrowsingContext context)
    {
        _browser = context;
    }

    public async Task<Invoice> ParseAsync(string html)
    {
        var invoice = new Invoice();

        var document = await _browser.OpenAsync(r => r.Content(html));

        var invoiceDiv = document.QuerySelector("div.invoice");
        if (invoiceDiv is null)
            return invoice;

        invoice.Name = invoiceDiv.QuerySelector(".name")?.TextContent.Trim();
        invoice.Address = invoiceDiv.QuerySelector(".address")?.TextContent.Trim();
        invoice.PaymentPurpose = invoiceDiv.QuerySelector(".paymentPurpose")?.TextContent.Trim();
        invoice.Institution = invoiceDiv.QuerySelector(".institution")?.TextContent.Trim();
        invoice.PaymentCode = invoiceDiv.QuerySelector(".paymentCode")?.TextContent.Trim();
        invoice.Amount = double.TryParse(invoiceDiv.QuerySelector(".amount")?.TextContent, out var amount) ? amount : 0;
        invoice.Account = invoiceDiv.QuerySelector(".account")?.TextContent.Trim();
        invoice.Model = invoiceDiv.QuerySelector(".model")?.TextContent.Trim();
        invoice.ReferenceNumber = invoiceDiv.QuerySelector(".referenceNumber")?.TextContent.Trim();
        invoice.CurrencyDate = DateTime.TryParseExact(invoiceDiv.QuerySelector(".currencyDate")?.TextContent.Trim(), "dd.MM.yyyy", null, DateTimeStyles.None, out var date) ? date : default;
        invoice.Currency = invoiceDiv.QuerySelector(".currency")?.TextContent.Trim();
        invoice.QrCode64 = invoiceDiv.QuerySelector<IHtmlImageElement>("img")?.Source?.Replace("data:image/png;base64,", "");

        return invoice;
    }
}
