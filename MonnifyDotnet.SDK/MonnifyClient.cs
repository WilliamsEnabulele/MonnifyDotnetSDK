using Microsoft.Extensions.Options;
using MonnifyDotnet.SDK.APIs;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;

namespace MonnifyDotnet.SDK
{
    public class MonnifyClient : IMonnifyClient
    {
        private readonly MonnifyOptions _options;
        private readonly HttpClient _client = new();
        private readonly BaseClient _baseClient;

        public MonnifyClient(MonnifyOptions options)
        {
            _options = options;
            ValidateOptions(_options);
            _baseClient = new BaseClient(_client, _options);
        }

        public MonnifyClient(IOptions<MonnifyOptions> options, BaseClient baseClient)
        {
            _options = options.Value;
            ValidateOptions(_options);
            _baseClient = baseClient;
        }

        private void ValidateOptions(MonnifyOptions options)
        {
            if (string.IsNullOrWhiteSpace(options.ApiKey))
                throw new ArgumentException("ApiKey is required", nameof(options.ApiKey));
            if (string.IsNullOrWhiteSpace(options.ApiSecret))
                throw new ArgumentException("ApiSecret is required", nameof(options.ApiSecret));
            if (string.IsNullOrWhiteSpace(options.BaseUrl))
                throw new ArgumentException("BaseUrl is required", nameof(options.BaseUrl));
        }

        public TransactionAPIs Transaction => new(_baseClient);

        public CustomerReservedAccountAPIs CustomerReservedAccount => new(_baseClient);

        public DirectDebitAPIs DirectDebit => new(_baseClient);

        public InvoiceAPIs Invoice => new(_baseClient);

        public RecurringPaymentAPIs RecurringPayment => new(_baseClient);

        public SubAccountAPIs SubAccount => new(_baseClient);

        public WalletAPIs Wallet => new(_baseClient);

        public TransferAPIs Transfer => new(_baseClient);

        public LimitProfileAPIs LimitProfile => new(_baseClient);

        public RefundAPIs Refund => new(_baseClient);

        public SettlementAPIs Settlement => new(_baseClient);

        public VerificationAPIs Verification => new(_baseClient);

        public OtherAPIs Others => new(_baseClient);

        public PaycodeAPIs PayCode => new(_baseClient);
    }
}