using System.Collections.Generic;
using System.Net.Http;
using CyberSourceMergedSpec.Api;
using CyberSourceMergedSpec.Core;
using CyberSourceMergedSpec.Core.Experimental.VisaHttpSignature;
using CyberSourceMergedSpec.Core.Hooks;
using CyberSourceMergedSpec.Core.Logging;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec;

/// <summary>
/// All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
/// </summary>
public sealed class CyberSourceMergedSpecClient
{
    public CyberSourceMergedSpecClient(HttpClient httpClient, CyberSourceMergedSpecClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "CyberSourceMergedSpecClient/0.0.1 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "0.0.1"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "CyberSourceMergedSpecClient");
        var visaHttpSignatureConfig = VisaHttpSignatureConfigResolver.Resolve();
        IReadOnlyList<SdkHook> hooks = options.Hooks;
        if (visaHttpSignatureConfig is not null)
            hooks = [.. hooks, new VisaHttpSignatureHook(visaHttpSignatureConfig)];
        var rawClient =
            new RawClient(httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                hooks);
        BinLookup = new BinLookup(rawClient, server);
        ChargebackDetails = new ChargebackDetails(rawClient, server);
        ChargebackSummaries = new ChargebackSummaries(rawClient, server);
        ConversionDetails = new ConversionDetails(rawClient, server);
        CustomerApi = new CustomerApi(rawClient, server);
        CustomerPaymentInstrument = new CustomerPaymentInstrument(rawClient, server);
        CustomerShippingAddress = new CustomerShippingAddress(rawClient, server);
        DecisionManager = new DecisionManager(rawClient, server);
        DownloadDtd = new DownloadDtd(rawClient, server);
        DownloadXsd = new DownloadXsd(rawClient, server);
        InstrumentIdentifierApi = new InstrumentIdentifierApi(rawClient, server);
        InterchangeClearingLevelDetails = new InterchangeClearingLevelDetails(rawClient, server);
        InvoiceSettings = new InvoiceSettings(rawClient, server);
        Invoices = new Invoices(rawClient, server);
        MerchantDefinedFields = new MerchantDefinedFields(rawClient, server);
        MicroformIntegration = new MicroformIntegration(rawClient, server);
        NetFundings = new NetFundings(rawClient, server);
        NetworkTokens = new NetworkTokens(rawClient, server);
        NotificationOfChanges = new NotificationOfChanges(rawClient, server);
        PayerAuthentication = new PayerAuthentication(rawClient, server);
        PaymentBatchSummaries = new PaymentBatchSummaries(rawClient, server);
        PaymentInstrumentApi = new PaymentInstrumentApi(rawClient, server);
        Payouts = new Payouts(rawClient, server);
        Plans = new Plans(rawClient, server);
        PullFundsApi = new PullFundsApi(rawClient, server);
        PurchaseAndRefundDetails = new PurchaseAndRefundDetails(rawClient, server);
        ReportDefinitions = new ReportDefinitions(rawClient, server);
        ReportDownloads = new ReportDownloads(rawClient, server);
        ReportSubscriptions = new ReportSubscriptions(rawClient, server);
        Reports = new Reports(rawClient, server);
        RetrievalDetails = new RetrievalDetails(rawClient, server);
        RetrievalSummaries = new RetrievalSummaries(rawClient, server);
        SearchTransactions = new SearchTransactions(rawClient, server);
        SecureFileShare = new SecureFileShare(rawClient, server);
        Subscriptions = new Subscriptions(rawClient, server);
        SubscriptionsFollowOns = new SubscriptionsFollowOns(rawClient, server);
        Tokenize = new Tokenize(rawClient, server);
        TransactionBatches = new TransactionBatches(rawClient, server);
        TransactionDetailsApi = new TransactionDetailsApi(rawClient, server);
        Verification = new Verification(rawClient, server);
        BillingAgreements = new BillingAgreements(rawClient, server);
        CaptureApi = new CaptureApi(rawClient, server);
        Credit = new Credit(rawClient, server);
        Orders = new Orders(rawClient, server);
        PaymentTokens = new PaymentTokens(rawClient, server);
        Payments = new Payments(rawClient, server);
        RefundApi = new RefundApi(rawClient, server);
        ReversalApi = new ReversalApi(rawClient, server);
        VoidApi = new VoidApi(rawClient, server);
    }

    public BinLookup BinLookup { get; }

    /// <summary>
    /// API for requesting Chargeback Details.
    /// </summary>
    public ChargebackDetails ChargebackDetails { get; }

    /// <summary>
    /// API for requesting Chargeback Summaries.
    /// </summary>
    public ChargebackSummaries ChargebackSummaries { get; }

    /// <summary>
    /// API for retrieving conversion data for merchant
    /// </summary>
    public ConversionDetails ConversionDetails { get; }

    /// <summary>
    /// A Customer can be linked to multiple Payment Instruments and Shipping Addresses.
    /// With one Payment Instrument and Shipping Address designated as the default.
    /// It stores merchant reference information for the Customer such as email and merchant defined data.
    /// </summary>
    public CustomerApi CustomerApi { get; }

    /// <summary>
    /// A Customer Payment Instrument is linked to a Customer and an Instrument Identifier.
    /// It stores additional information in relation to a card number(PAN) or bank account (echeck).
    /// </summary>
    public CustomerPaymentInstrument CustomerPaymentInstrument { get; }

    /// <summary>
    /// A Customer Shipping Address is linked to a Customer.
    /// It stores shipping information in relation to the Customer.
    /// </summary>
    public CustomerShippingAddress CustomerShippingAddress { get; }

    /// <summary>
    /// REST API for the Decision Manager Service
    /// </summary>
    public DecisionManager DecisionManager { get; }

    /// <summary>
    /// API to download report DTDs
    /// </summary>
    public DownloadDtd DownloadDtd { get; }

    /// <summary>
    /// API to download report XSDs
    /// </summary>
    public DownloadXsd DownloadXsd { get; }

    /// <summary>
    /// An Instrument Identifier represents a unique card number(PAN) or bank account (echeck).
    /// It can also be associated with a Network Token that can be used for payment transactions.
    /// </summary>
    public InstrumentIdentifierApi InstrumentIdentifierApi { get; }

    /// <summary>
    /// API for requesting Interchange Clearing Level data for an account or a merchant.
    /// </summary>
    public InterchangeClearingLevelDetails InterchangeClearingLevelDetails { get; }

    /// <summary>
    /// Update the settings for the invoice payment page.
    /// </summary>
    public InvoiceSettings InvoiceSettings { get; }

    /// <summary>
    /// Offer your customers a simple, convenient, and fast way to pay with the new online invoicing tool.
    /// </summary>
    public Invoices Invoices { get; }

    public MerchantDefinedFields MerchantDefinedFields { get; }

    public MicroformIntegration MicroformIntegration { get; }

    /// <summary>
    /// API for retrieving the netfunding data for an account or a merchant
    /// </summary>
    public NetFundings NetFundings { get; }

    /// <summary>
    /// A Network Token represents a tokenized version of a card number (PAN) that can be used for payment transactions and, it's represented by a Tokenized Card in TMS.
    /// </summary>
    public NetworkTokens NetworkTokens { get; }

    /// <summary>
    /// API for Notification Of Change
    /// </summary>
    public NotificationOfChanges NotificationOfChanges { get; }

    public PayerAuthentication PayerAuthentication { get; }

    /// <summary>
    /// API for payment batch summary reports
    /// </summary>
    public PaymentBatchSummaries PaymentBatchSummaries { get; }

    /// <summary>
    /// A stand-alone Payment Instrument is linked to an Instrument Identifier.
    /// It stores additional information in relation to a card number(PAN) or bank account (echeck).
    /// </summary>
    public PaymentInstrumentApi PaymentInstrumentApi { get; }

    /// <summary>
    /// A payout enables an originator to send funds on behalf of itself, merchants, or customers to credit card
    /// accounts using an Original Credit Transaction (OCT). An originator is a merchant, government entity, or
    /// corporation with a merchant account from an acquiring bank.
    /// </summary>
    public Payouts Payouts { get; }

    /// <summary>
    /// Create and manage Plans for subscriptions.
    /// </summary>
    public Plans Plans { get; }

    /// <summary>
    /// Cybersource Payouts Funds Transfer REST API for Account Funding Transaction (AFT)
    /// </summary>
    public PullFundsApi PullFundsApi { get; }

    /// <summary>
    /// API for Purchase and Refund Details
    /// </summary>
    public PurchaseAndRefundDetails PurchaseAndRefundDetails { get; }

    /// <summary>
    /// Get report definition information
    /// </summary>
    public ReportDefinitions ReportDefinitions { get; }

    /// <summary>
    /// API for creation and retrieval of Reports
    /// </summary>
    public ReportDownloads ReportDownloads { get; }

    /// <summary>
    /// API for creation and retrieval of Report Subscriptions
    /// </summary>
    public ReportSubscriptions ReportSubscriptions { get; }

    /// <summary>
    /// API for creation and retrieval of Reports
    /// </summary>
    public Reports Reports { get; }

    /// <summary>
    /// API for requesting Retrieval Details.
    /// </summary>
    public RetrievalDetails RetrievalDetails { get; }

    /// <summary>
    /// API for requesting Retrieval Summaries
    /// </summary>
    public RetrievalSummaries RetrievalSummaries { get; }

    public SearchTransactions SearchTransactions { get; }

    public SecureFileShare SecureFileShare { get; }

    /// <summary>
    /// Create and manage Recurring Subscriptions.
    /// <para>
    /// You have option to link subscription to plan or create independent subscriptions.
    /// </para>
    /// </summary>
    public Subscriptions Subscriptions { get; }

    /// <summary>
    /// Create a Follow-On Subscription from an already existing successful Transaction.
    /// <para>
    /// You have option to link subscription to plan or create independent subscriptions.
    /// </para>
    /// </summary>
    public SubscriptionsFollowOns SubscriptionsFollowOns { get; }

    /// <summary>
    /// An orchestration resource used to combine multiple API calls into a single request.
    /// </summary>
    public Tokenize Tokenize { get; }

    /// <summary>
    /// Get a list of batch files or details of Individual file processed through the Offline Transaction Submission Services.
    /// </summary>
    public TransactionBatches TransactionBatches { get; }

    public TransactionDetailsApi TransactionDetailsApi { get; }

    public Verification Verification { get; }

    /// <summary>
    /// A billingAgreement is a stand-alone transaction that is not linked to any previous transactions. It takes money from
    /// your merchant bank account and returns it to the customer.
    /// </summary>
    public BillingAgreements BillingAgreements { get; }

    /// <summary>
    /// When you are ready to fulfill a customer’s order and transfer funds from the customer’s
    /// bank to your bank, capture the payment for that order.
    /// </summary>
    public CaptureApi CaptureApi { get; }

    /// <summary>
    /// A credit is a stand-alone transaction that is not linked to any previous transactions. It takes money from
    /// your merchant bank account and returns it to the customer.
    /// </summary>
    public Credit Credit { get; }

    /// <summary>
    /// An order is a service that is used for initiating a transaction with itemized details, shipping, billing and buyer information.
    /// </summary>
    public Orders Orders { get; }

    /// <summary>
    /// A payment-tokens is a service that is used for retrieving vault details or deleting vault id/payment method.
    /// </summary>
    public PaymentTokens PaymentTokens { get; }

    /// <summary>
    /// A payment authorizes the amount for the transaction. There are a number of supported payment
    /// instruments, such as Credit Card, Debit Card, e-Wallet, and Alternative Payments. A payment
    /// response includes the status of the request. It also includes processor-specific information
    /// when the request is successful and errors if unsuccessful.
    /// </summary>
    public Payments Payments { get; }

    /// <summary>
    /// A refund is a follow-on transaction that uses the ID returned from either a payment or capture request.
    /// </summary>
    public RefundApi RefundApi { get; }

    /// <summary>
    /// An authorization reversal releases the hold that the payment placed on the customer’s funds.
    /// </summary>
    public ReversalApi ReversalApi { get; }

    /// <summary>
    /// A void cancels a payment or capture. A transaction can be voided only when CyberSource has not already
    /// submitted the capture to your processor. You cannot undo a void.
    /// </summary>
    public VoidApi VoidApi { get; }
}
