using MonnifyDotnet.SDK.APIs;

namespace MonnifyDotnet.SDK
{
    public interface IMonnifyClient
    {
        TransactionAPIs Transaction { get; }

        CustomerReservedAccountAPIs CustomerReservedAccount { get; }

        DirectDebitAPIs DirectDebit { get; }

        InvoiceAPIs Invoice { get; }

        RecurringPaymentAPIs RecurringPayment { get; }

        SubAccountAPIs SubAccount { get; }

        WalletAPIs Wallet { get; }

        TransferAPIs Transfer { get; }

        LimitProfileAPIs LimitProfile { get; }

        RefundAPIs Refund { get; }

        SettlementAPIs Settlement { get; }

        VerificationAPIs Verification { get; }

        OtherAPIs Others { get; }

        PaycodeAPIs PayCode { get; }
    }
}