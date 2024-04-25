using AngleSharp;
using Microsoft.Web.WebView2.Core;
using System.Text.Json;

namespace Eplati;

public partial class Form1 : Form
{
    private readonly IBrowsingContext _browsingContext;
    private readonly HtmlParser _htmlParser;
    private readonly Uri _url = new(@"https://plati.euprava.gov.rs/");

    public Form1()
    {
        InitializeComponent();

        _browsingContext = BrowsingContext.New(Configuration.Default);
        _htmlParser = new HtmlParser(_browsingContext);
    }

    #region WebView
    private void webView21_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
    {
        webView21.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
    }

    private void CoreWebView2_NewWindowRequested(object? sender, CoreWebView2NewWindowRequestedEventArgs e)
    {
        e.Handled = true;

        var newWindow = sender as CoreWebView2;

        if (newWindow != null)
        {
            e.NewWindow = newWindow;
        }
    }

    private void webView21_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
    {
        textBox1.Text = webView21.Source.AbsoluteUri;
    }

    private async Task<string> GetHtmlAsync()
    {
        var jsonHtml = await webView21.CoreWebView2.ExecuteScriptAsync(@"document.getElementsByClassName('invoice')[0].outerHTML;");
        return jsonHtml is null ? string.Empty : JsonSerializer.Deserialize<string>(jsonHtml) ?? string.Empty;
    }
    #endregion

    private async void btnCopy_Click(object sender, EventArgs e)
    {
        var text = await GetHtmlAsync();

        if (!string.IsNullOrWhiteSpace(text))
        {
            var invoice = await _htmlParser.ParseAsync(text);
            PopulateTextBoxesWith(invoice);

            tabControl1.SelectedIndex = 1;
        }
        else
        {
            MessageBox.Show("Prvo napravi uplatnicu!", "Obaveštenje");
        }
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        webView21.Source = _url;
        PopulateTextBoxesWith(new Invoice());
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        _browsingContext.Dispose();
    }

    private void PopulateTextBoxesWith(Invoice invoice)
    {
        txtName.Text = invoice.Name;
        txtInstitution.Text = $"{invoice.Institution} {invoice.Address}";
        txtPurpose.Text = invoice.PaymentPurpose;
        txtPaymentCode.Text = invoice.PaymentCode;
        txtAmount.Text = invoice.Amount.ToString("n2");
        txtAccount.Text = invoice.Account;
        txtModel.Text = invoice.Model;
        txtReferenceNumber.Text = invoice.ReferenceNumber;
        txtCurrencyDate.Text = invoice.CurrencyDate?.ToString("d");
        txtCurrrency.Text = invoice.Currency;

        if (!string.IsNullOrWhiteSpace(invoice.QrCode64))
        {
            var bytes = Convert.FromBase64String(invoice.QrCode64);
            using var stream = new MemoryStream(bytes);
            pbQrCode.Image = Image.FromStream(stream);
        }
        else
        {
            pbQrCode.Image = null;
        }
    }
}
