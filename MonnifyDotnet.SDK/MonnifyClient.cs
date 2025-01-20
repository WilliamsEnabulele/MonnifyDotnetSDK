using Microsoft.Extensions.Options;
using MonnifyDotnet.SDK.APIs;
using MonnifyDotnet.SDK.Models;
using MonnifyDotnet.SDK.Shared;

namespace MonnifyDotnet.SDK
{
    public class MonnifyClient : IMonnifyClient
    {
        private readonly MonnifyOptions _options;
        private readonly HttpClient _client;
        private readonly BaseClient _baseService;

        public MonnifyClient(MonnifyOptions options)
        {
            _options = options;
            ValidateOptions(_options);

            _client = new HttpClient();
            var authService = new AuthAPI(_options);
            _baseService = new BaseClient(_client, _options);
        }

        public MonnifyClient(IOptions<MonnifyOptions> options, IHttpClientFactory factory)
        {
            _options = options.Value;
            ValidateOptions(_options);

            _client = factory.CreateClient();
            var authService = new AuthAPI(_options);
            _baseService = new BaseClient(_client, _options);
        }


        private void ValidateOptions(MonnifyOptions options)
        {
            if (string.IsNullOrWhiteSpace(options.ApiKey))
                throw new ArgumentException("ApiKey is required", nameof(options.ApiKey));
            if (string.IsNullOrWhiteSpace(options.ApiSecret))
                throw new ArgumentException("SecretKey is required", nameof(options.ApiSecret));
            if (string.IsNullOrWhiteSpace(options.BaseUrl))
                throw new ArgumentException("BaseUrl is required", nameof(options.BaseUrl));
        }

        public TransactionAPIs Transaction => new(_baseService);

        public CustomerReservedAccountAPIs CustomerReservedAccount => new(_baseService);

        public DirectDebitAPIs DirectDebit => new(_baseService);

        public InvoiceAPIs Invoice => new(_baseService);

        public RecurringPaymentAPIs RecurringPayment => new(_baseService);

        public SubAccountAPIs SubAccount => new(_baseService);

        public WalletAPIs Wallet => new(_baseService);

        public TransferAPIs Transfer => new(_baseService);

        public LimitProfileAPIs LimitProfile => new(_baseService);

        public RefundAPIs Refund => new(_baseService);

        public SettlementAPIs Settlement => new(_baseService);

        public VerificationAPIs Verification => new(_baseService);

        public OtherAPIs Others => new(_baseService);

        public PaycodeAPIs PayCode => new(_baseService);
    }
}