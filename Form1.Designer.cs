namespace Eplati;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
        btnReset = new Button();
        btnCopy = new Button();
        textBox1 = new TextBox();
        tabPage2 = new TabPage();
        pbQrCode = new PictureBox();
        txtReferenceNumber = new TextBox();
        txtAmount = new TextBox();
        txtCurrrency = new TextBox();
        txtCurrencyDate = new TextBox();
        txtModel = new TextBox();
        label9 = new Label();
        txtPaymentCode = new TextBox();
        label6 = new Label();
        txtAccount = new TextBox();
        label10 = new Label();
        txtInstitution = new TextBox();
        label8 = new Label();
        label5 = new Label();
        label4 = new Label();
        label7 = new Label();
        txtPurpose = new TextBox();
        label3 = new Label();
        label2 = new Label();
        txtName = new TextBox();
        label1 = new Label();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
        tabPage2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pbQrCode).BeginInit();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.Location = new Point(0, 0);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(784, 561);
        tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(webView21);
        tabPage1.Controls.Add(btnReset);
        tabPage1.Controls.Add(btnCopy);
        tabPage1.Controls.Add(textBox1);
        tabPage1.Location = new Point(4, 24);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(776, 533);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Pretraživač";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // webView21
        // 
        webView21.AllowExternalDrop = true;
        webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        webView21.CreationProperties = null;
        webView21.DefaultBackgroundColor = Color.White;
        webView21.Location = new Point(3, 48);
        webView21.Name = "webView21";
        webView21.Size = new Size(770, 482);
        webView21.Source = new Uri("https://plati.euprava.gov.rs/", UriKind.Absolute);
        webView21.TabIndex = 3;
        webView21.ZoomFactor = 1D;
        webView21.CoreWebView2InitializationCompleted += webView21_CoreWebView2InitializationCompleted;
        webView21.SourceChanged += webView21_SourceChanged;
        // 
        // btnReset
        // 
        btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnReset.Location = new Point(680, 6);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(88, 23);
        btnReset.TabIndex = 1;
        btnReset.Text = "Resetuj";
        btnReset.UseVisualStyleBackColor = true;
        btnReset.Click += btnReset_Click;
        // 
        // btnCopy
        // 
        btnCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCopy.Location = new Point(586, 6);
        btnCopy.Name = "btnCopy";
        btnCopy.Size = new Size(88, 23);
        btnCopy.TabIndex = 1;
        btnCopy.Text = "Kopiraj nalog";
        btnCopy.UseVisualStyleBackColor = true;
        btnCopy.Click += btnCopy_Click;
        // 
        // textBox1
        // 
        textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        textBox1.Enabled = false;
        textBox1.Location = new Point(8, 6);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(572, 23);
        textBox1.TabIndex = 0;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(pbQrCode);
        tabPage2.Controls.Add(txtReferenceNumber);
        tabPage2.Controls.Add(txtAmount);
        tabPage2.Controls.Add(txtCurrrency);
        tabPage2.Controls.Add(txtCurrencyDate);
        tabPage2.Controls.Add(txtModel);
        tabPage2.Controls.Add(label9);
        tabPage2.Controls.Add(txtPaymentCode);
        tabPage2.Controls.Add(label6);
        tabPage2.Controls.Add(txtAccount);
        tabPage2.Controls.Add(label10);
        tabPage2.Controls.Add(txtInstitution);
        tabPage2.Controls.Add(label8);
        tabPage2.Controls.Add(label5);
        tabPage2.Controls.Add(label4);
        tabPage2.Controls.Add(label7);
        tabPage2.Controls.Add(txtPurpose);
        tabPage2.Controls.Add(label3);
        tabPage2.Controls.Add(label2);
        tabPage2.Controls.Add(txtName);
        tabPage2.Controls.Add(label1);
        tabPage2.Location = new Point(4, 24);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(776, 533);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Nalog";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // pbQrCode
        // 
        pbQrCode.Location = new Point(533, 304);
        pbQrCode.Name = "pbQrCode";
        pbQrCode.Size = new Size(200, 200);
        pbQrCode.SizeMode = PictureBoxSizeMode.StretchImage;
        pbQrCode.TabIndex = 2;
        pbQrCode.TabStop = false;
        // 
        // txtReferenceNumber
        // 
        txtReferenceNumber.Location = new Point(111, 275);
        txtReferenceNumber.Name = "txtReferenceNumber";
        txtReferenceNumber.Size = new Size(622, 23);
        txtReferenceNumber.TabIndex = 1;
        txtReferenceNumber.TabStop = false;
        // 
        // txtAmount
        // 
        txtAmount.Location = new Point(194, 183);
        txtAmount.Name = "txtAmount";
        txtAmount.Size = new Size(539, 23);
        txtAmount.TabIndex = 1;
        txtAmount.TabStop = false;
        // 
        // txtCurrrency
        // 
        txtCurrrency.Location = new Point(111, 183);
        txtCurrrency.Name = "txtCurrrency";
        txtCurrrency.Size = new Size(77, 23);
        txtCurrrency.TabIndex = 1;
        txtCurrrency.TabStop = false;
        // 
        // txtCurrencyDate
        // 
        txtCurrencyDate.Location = new Point(28, 324);
        txtCurrencyDate.Name = "txtCurrencyDate";
        txtCurrencyDate.Size = new Size(158, 23);
        txtCurrencyDate.TabIndex = 1;
        txtCurrencyDate.TabStop = false;
        // 
        // txtModel
        // 
        txtModel.Location = new Point(28, 275);
        txtModel.Name = "txtModel";
        txtModel.Size = new Size(77, 23);
        txtModel.TabIndex = 1;
        txtModel.TabStop = false;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(111, 257);
        label9.Name = "label9";
        label9.Size = new Size(75, 15);
        label9.TabIndex = 0;
        label9.Text = "Poziv na broj";
        // 
        // txtPaymentCode
        // 
        txtPaymentCode.Location = new Point(28, 183);
        txtPaymentCode.Name = "txtPaymentCode";
        txtPaymentCode.Size = new Size(77, 23);
        txtPaymentCode.TabIndex = 1;
        txtPaymentCode.TabStop = false;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(194, 165);
        label6.Name = "label6";
        label6.Size = new Size(34, 15);
        label6.TabIndex = 0;
        label6.Text = "Iznos";
        // 
        // txtAccount
        // 
        txtAccount.Location = new Point(28, 229);
        txtAccount.Name = "txtAccount";
        txtAccount.Size = new Size(705, 23);
        txtAccount.TabIndex = 1;
        txtAccount.TabStop = false;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(28, 306);
        label10.Name = "label10";
        label10.Size = new Size(78, 15);
        label10.TabIndex = 0;
        label10.Text = "Datum valute";
        // 
        // txtInstitution
        // 
        txtInstitution.Location = new Point(28, 134);
        txtInstitution.Name = "txtInstitution";
        txtInstitution.Size = new Size(705, 23);
        txtInstitution.TabIndex = 1;
        txtInstitution.TabStop = false;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(28, 257);
        label8.Name = "label8";
        label8.Size = new Size(71, 15);
        label8.TabIndex = 0;
        label8.Text = "Broj modela";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(111, 165);
        label5.Name = "label5";
        label5.Size = new Size(39, 15);
        label5.TabIndex = 0;
        label5.Text = "Valuta";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(28, 165);
        label4.Name = "label4";
        label4.Size = new Size(77, 15);
        label4.TabIndex = 0;
        label4.Text = "Šifra plaćanja";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(28, 211);
        label7.Name = "label7";
        label7.Size = new Size(93, 15);
        label7.TabIndex = 0;
        label7.Text = "Račun primaoca";
        // 
        // txtPurpose
        // 
        txtPurpose.Location = new Point(28, 88);
        txtPurpose.Name = "txtPurpose";
        txtPurpose.Size = new Size(705, 23);
        txtPurpose.TabIndex = 1;
        txtPurpose.TabStop = false;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(28, 116);
        label3.Name = "label3";
        label3.Size = new Size(53, 15);
        label3.TabIndex = 0;
        label3.Text = "Primalac";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(28, 70);
        label2.Name = "label2";
        label2.Size = new Size(72, 15);
        label2.TabIndex = 0;
        label2.Text = "Svrha uplate";
        // 
        // txtName
        // 
        txtName.Location = new Point(28, 41);
        txtName.Name = "txtName";
        txtName.Size = new Size(705, 23);
        txtName.TabIndex = 1;
        txtName.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(28, 23);
        label1.Name = "label1";
        label1.Size = new Size(53, 15);
        label1.TabIndex = 0;
        label1.Text = "Uplatilac";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 561);
        Controls.Add(tabControl1);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "E-plati";
        FormClosing += Form1_FormClosing;
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
        tabPage2.ResumeLayout(false);
        tabPage2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pbQrCode).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    private Button btnCopy;
    private TextBox textBox1;
    private TextBox txtName;
    private Label label1;
    private TextBox txtPurpose;
    private Label label2;
    private TextBox txtInstitution;
    private Label label3;
    private TextBox txtReferenceNumber;
    private TextBox txtAmount;
    private TextBox txtCurrrency;
    private TextBox txtModel;
    private Label label9;
    private TextBox txtPaymentCode;
    private Label label6;
    private TextBox txtAccount;
    private Label label8;
    private Label label5;
    private Label label4;
    private Label label7;
    private PictureBox pbQrCode;
    private TextBox txtCurrencyDate;
    private Label label10;
    private Button btnReset;
}
