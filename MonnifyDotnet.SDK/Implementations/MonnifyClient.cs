using MonnifyDotnet.SDK.Interfaces;
using MonnifyDotnet.SDK.Models;

namespace MonnifyDotnet.SDK.Implementations
{
    public class MonnifyClient : IMonnifyClient
    {
        private readonly MonnifyOptions _options;
        private readonly HttpClient _client;
        private readonly BaseService _baseService;

        public MonnifyClient(MonnifyOptions options)
        {
            _options = options;
            _client = new HttpClient();
            var authService = new AuthService(_client, _options);
            _baseService = new BaseService(_client, authService, _options);
        }

        public ITransactionService Transaction => new TransactionService(_baseService);

        public ICustomerReservedAccountService CustomerReservedAccount => new CustomerReservedAccountService(_baseService);

        public IDirectDebitService DirectDebit => new DirectDebitService(_baseService);

        public IInvoiceService Invoice => new InvoiceService(_baseService);

        public IRecurringPaymentService RecurringPayment => new RecurringPaymentService(_baseService);

        public ISubAccountService SubAccount => new SubAccountService(_baseService);

        public IWalletService Wallet => new WalletService(_baseService);

        public ITransferService Transfer => new TransferService(_baseService);

        public ILimitProfileService LimitProfile => new LimitProfileService(_baseService);

        public IRefundService Refund => new RefundService(_baseService);

        public ISettlementService Settlement => new SettlementService(_baseService);

        public IVerificationService Verification => new VerificationService(_baseService);

        public IOtherService Others => new OtherService(_baseService);

        public IPayCodeService PayCode => new PaycodeService(_baseService);
    }
}