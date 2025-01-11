namespace MonnifyDotnetSDK.src.Shared
{
    public static class TransactionUrls
    {
        public const string InitializeTransaction = "/api/v1/merchant/transactions/init-transaction";
        public const string PayWithBankTransafer = "/api/v1/merchant/bank-transfer/init-payment";
        public const string PayWithUSSD = "/api/v1/merchant/ussd/initialize";
        public const string ChargeCard = "/api/v1/merchant/cards/charge";
        public const string AuthorizeOTP = "/api/v1/merchant/cards/otp/authorize";
        public const string Authorize3DS = "/api/v1/sdk/cards/secure-3d/authorize";
        public const string GetAllTransactions = "/api/v1/transactions/search";
        public const string GetTransactionStatus = "/api/v2/transactions";
        public const string GetStatusByReference = "/api/v2/merchant/transactions/query";
    }

    public static class CustomerReservedAccountUrls
    {
        public const string CreateReservedAccountGeneral = "/api/v2/bank-transfer/reserved-accounts";
        public const string CreateReservedAccountInvoice = "/api/v1/bank-transfer/reserved-accounts";
        public const string GetReservedAccountDetails = "/api/v2/bank-transfer/reserved-accounts/{accountReference}";
        public const string AddLinkedAccount = "api/v1/bank-transfer/reserved-accounts/add-linked-accounts/{accountReference}";
        public const string UpdateBVNForAReserveAccount = "/api/v1/bank-transfer/reserved-accounts/update-customer-bvn/{accountReference}";
        public const string AllowedPaymentSource = "/api/v1/bank-transfer/reserved-accounts/update-payment-source-filter/{accountReference}";
        public const string UpdatingSplitConfigForReservedAccount = "/api/v1/bank-transfer/reserved-accounts/update-income-split-config/{accountReference}";
        public const string DeallocatingAReservedAccount = "/api/v1/bank-transfer/reserved-accounts/reference/{accountReference}";
        public const string GetReservedAccountTransactions = "/api/v1/bank-transfer/reserved-accounts/transactions";
        public const string UpdateKYCInfo = "/api/v1/bank-transfer/reserved-accounts/{accountReference}/kyc-info";
    }

    public static class InvoicesUrls
    {
        public const string Invoice = "/api/v1/invoice/create";
        public const string ViewInvoiceDetails = "/api/v1/invoice/{invoiceReference}/details";
        public const string GetAllInvoices = "/api/v1/invoice/all";
        public const string CancelAnInvoice = "/api/v1/invoice/{invoiceReference}/cancel";
    }

    public static class RecurringPaymentUrls
    {
        public const string ChargeCardToken = "/api/v1/merchant/cards/charge-card-token";
    }

    public static class DirectDebitUrls
    {
        public const string CreateMandate = "/api/v1/direct-debit/mandate/create";
        public const string GetMandateStatus = "/api/v1/direct-debit/mandate/";
        public const string DebitMandate = "/api/v1/direct-debit/mandate/debit";
        public const string GetDebitStatus = "/api/v1/direct-debit/mandate/debit-status";
        public const string UpdateMandate = "/api/v1/direct-debit/mandate/cancel-mandate/{{mandateCode}}";
    }

    public static class SubAccountUrls
    {
        public const string SubAccount = "/api/v1/sub-accounts";
        public const string DeleteSubAccount = "/api/v1/sub-accounts/{subAccountCode}";
    }

    public static class TransferUrls
    {
        public const string InitiateTransfer = "/api/v2/disbursements/single";
        public const string InitiateBulkTransfer = "/api/v2/disbursements/batch";
        public const string AuthorizeSingleTransfer = "/api/v2/disbursements/single/validate-otp";
        public const string AuthorizeBulkTransfer = "/api/v2/disbursements/batch/validate-otp";
        public const string ResendOTP = "/api/v2/disbursements/single/resend-otp";
        public const string SingleTransferStatus = "/api/v2/disbursements/single/summary";
        public const string ListAllSingleTransfers = "/api/v2/disbursements/single/transactions";
        public const string ListAllBulkTransfers = "/api/v2/disbursements/bulk/transactions";
        public const string GetAllBulkTransferTransactions = "/api/v2/disbursements/bulk/batchreference--12934/transactions";
        public const string BulkTransferStatus = "/api/v2/disbursements/{bulk/batchreference}/transactions";
        public const string SearchDisbursementTransactions = "/api/v2/disbursements/search-transactions";
        public const string GetWalletBalance = "/api/v2/disbursements/wallet-balance";
    }

    public static class WalletUrls
    {
        public const string Create = "/api/v1/disbursements/wallet";
        public const string Balance = "/api/v1/disbursements/wallet/balance";
        public const string Wallet = "/api/v1/disbursements/wallet";
        public const string Transactions = "/api/v1/disbursements/wallet/transactions";
    }

    public static class LimitProfileUrls
    {
        public const string profile = "/api/v1/limit-profile/";
        public const string ReserveAccountWithLimit = "/api/v2/bank-transfer/reserved-accounts/limit";
    }

    public static class RefundUrls
    {
        public const string InitiateRefund = "/api/v1/refunds/initiate-refund";
        public const string GetRefundStatus = "/api/v1/refunds/{refundReference}";
        public const string GetAllRefunds = "/api/v1/refunds";
    }

    public static class SettlementUrls
    {
        public const string GetTransactionsBySettlementReference = "/api/v1/transactions/find-by-settlement-reference";
        public const string GetSettlementsInformation = "/api/v1/settlement-detail";
    }

    public static class VerificationUrls
    {
        public const string ValidateBankAccount = "/api/v1/disbursements/account/validate";
        public const string BVNInformationVerification = "/api/v1/vas/bvn-details-match";
        public const string BVNAndAccountNameMatch = "/api/v1/vas/bvn-account-match";
        public const string NINVerification = "/api/v1/vas/nin-details";
    }

    public static class OtherUrls
    {
        public const string GetBanks = "/api/v1/banks";
        public const string GetBanksWithUSSDShortCode = "/api/v1/sdk/transactions/banks";
    }

    public static class PayCodeUrls
    {
        public const string Paycode = "/api/v1/paycode";
        public const string GetPaycode = "/api/v1/paycode/{{paycodeReference}}";
        public const string GetClearPaycode = "/api/v1/paycode/{{paycodeReference}}/authorize";
        public const string DeletePaycode = "/api/v1/paycode/{{paycodeReference}}";
    }
}