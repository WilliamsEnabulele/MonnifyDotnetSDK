namespace MonnifyDotnet.SDK.Interfaces
{
    public interface IMonnifyClient
    {
        ITransactionService Transaction { get; }

        ICustomerReservedAccountService CustomerReservedAccount { get; }

        IDirectDebitService DirectDebit { get; }

        IInvoiceService Invoice { get; }

        IRecurringPaymentService RecurringPayment { get; }

        ISubAccountService SubAccount { get; }

        IWalletService Wallet { get; }

        ITransferService Transfer { get; }

        ILimitProfileService LimitProfile { get; }

        IRefundService Refund { get; }

        ISettlementService Settlement { get; }

        IVerificationService Verification { get; }

        IOtherService Others { get; }

        IPayCodeService PayCode { get; }
    }
}