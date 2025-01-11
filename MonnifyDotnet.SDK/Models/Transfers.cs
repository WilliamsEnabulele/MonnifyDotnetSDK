using Newtonsoft.Json;

namespace MonnifyDotnet.SDK.Models
{
    public class InitiateTransferRequest
    {
        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("narration")]
        public string Narration { get; set; }

        [JsonProperty("destinationBankCode")]
        public string DestinationBankCode { get; set; }

        [JsonProperty("destinationAccountNumber")]
        public string DestinationAccountNumber { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("sourceAccountNumber")]
        public string SourceAccountNumber { get; set; }

        public InitiateTransferRequest(
            float amount,
            string reference,
            string narration,
            string destinationBankCode,
            string destinationAccountNumber,
            string currency,
            string sourceAccountNumber)
        {
            Amount = amount;
            Reference = reference ?? throw new ArgumentNullException(nameof(reference));
            Narration = narration ?? throw new ArgumentNullException(nameof(narration));
            DestinationBankCode = destinationBankCode ?? throw new ArgumentNullException(nameof(destinationBankCode));
            DestinationAccountNumber = destinationAccountNumber ?? throw new ArgumentNullException(nameof(destinationAccountNumber));
            Currency = currency ?? throw new ArgumentNullException(nameof(currency));
            SourceAccountNumber = sourceAccountNumber ?? throw new ArgumentNullException(nameof(sourceAccountNumber));
        }
    }

    public class InitiateTransferAsyncTransfer { 
        [JsonProperty("async")]
        public bool Async { get; set; }

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("narration")]
        public string Narration { get; set; }

        [JsonProperty("destinationBankCode")]
        public string DestinationBankCode { get; set; }

        [JsonProperty("destinationAccountNumber")]
        public string DestinationAccountNumber { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("sourceAccountNumber")]
        public string SourceAccountNumber { get; set; }

        public InitiateTransferAsyncTransfer(
            bool async,
            float amount,
            string reference,
            string narration,
            string destinationBankCode,
            string destinationAccountNumber,
            string currency,
            string sourceAccountNumber)
        {
            Async = async;
            Amount = amount;
            Reference = reference ?? throw new ArgumentNullException(nameof(reference));
            Narration = narration ?? throw new ArgumentNullException(nameof(narration));
            DestinationBankCode = destinationBankCode ?? throw new ArgumentNullException(nameof(destinationBankCode));
            DestinationAccountNumber = destinationAccountNumber ?? throw new ArgumentNullException(nameof(destinationAccountNumber));
            Currency = currency ?? throw new ArgumentNullException(nameof(currency));
            SourceAccountNumber = sourceAccountNumber ?? throw new ArgumentNullException(nameof(sourceAccountNumber));
        }
    }

    public class TransferResponse
    {
        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("dateCreated")]
        public DateTime DateCreated { get; set; }

        [JsonProperty("totalFee")]
        public float TotalFee { get; set; }

        [JsonProperty("destinationAccountName")]
        public string? DestinationAccountName { get; set; }

        [JsonProperty("destinationBankName")]
        public string? DestinationBankName { get; set; }

        [JsonProperty("destinationAccountNumber")]
        public string? DestinationAccountNumber { get; set; }

        [JsonProperty("destinationBankCode")]
        public string? DestinationBankCode { get; set; }
    }

    public class InitiateTransferBulkRequest
    {
        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("batchReference")]
        public string? BatchReference { get; set; }

        [JsonProperty("narration")]
        public string? Narration { get; set; }

        [JsonProperty("sourceAccountNumber")]
        public string? SourceAccountNumber { get; set; }

        [JsonProperty("onValidationFailure")]
        public string? OnValidationFailure { get; set; }

        [JsonProperty("notificationInterval")]
        public int NotificationInterval { get; set; }

        [JsonProperty("transactionList")]
        public TransactionList[]? TransactionList { get; set; }
    }

    public class TransactionList
    {
        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("narration")]
        public string? Narration { get; set; }

        [JsonProperty("destinationBankCode")]
        public string? DestinationBankCode { get; set; }

        [JsonProperty("destinationAccountNumber")]
        public string? DestinationAccountNumber { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }
    }

    public class TransferBulkResponse
    {
        [JsonProperty("totalAmount")]
        public float TotalAmount { get; set; }

        [JsonProperty("totalFee")]
        public float TotalFee { get; set; }

        [JsonProperty("batchReference")]
        public string? BatchReference { get; set; }

        [JsonProperty("batchStatus")]
        public string? BatchStatus { get; set; }

        [JsonProperty("totalTransactionsCount")]
        public int TotalTransactionsCount { get; set; }

        [JsonProperty("dateCreated")]
        public DateTime DateCreated { get; set; }
    }

    public class AuthorizeSingleTransferRequest
    {
        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("authorizationCode")]
        public string? AuthorizationCode { get; set; }
    }

    public class ResentOTPRequest
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        public ResentOTPRequest(string reference)
        {
            Reference = reference ?? throw new ArgumentNullException(nameof(reference));
        }
    }

        public class ResendOTPResponse
    {
        [JsonProperty("message")]
        public string? Message { get; set; }
    }

    public class BaseFilterRequest
    {
        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("pageNo")]
        public int PageNo { get; set; }
    }

    public class SearchDisbursementTransactionsRequest : BaseFilterRequest
    {
        [JsonProperty("startDate")]
        public string? StartDate { get; set; }

        [JsonProperty("endDate")]
        public string? EndDate { get; set; }

        [JsonProperty("amountFrom")]
        public string? AmountFrom { get; set; }

        [JsonProperty("amountTo")]
        public string? AmountTo { get; set; }
    }

    public class WalletBalance
    {
        [JsonProperty("availableBalance")]
        public float AvailableBalance { get; set; }

        [JsonProperty("ledgerBalance")]
        public float LedgerBalance { get; set; }
    }


    public class SingleTransferStatusResponse
    {
        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("reference")]
        public string? Reference { get; set; }

        [JsonProperty("narration")]
        public string? Narration { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("fee")]
        public float Fee { get; set; }

        [JsonProperty("two_fa_enabled")]
        public bool TwoFaEnabled { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("transaction_description")]
        public string? TransactionDescription { get; set; }

        [JsonProperty("transaction_reference")]
        public string? TransactionReference { get; set; }

        [JsonProperty("created_on")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("source_account_number")]
        public string? SourceAccountNumber { get; set; }

        [JsonProperty("destination_account_number")]
        public string? DestinationAccountNumber { get; set; }

        [JsonProperty("destination_account_name")]
        public string? DestinationAccountName { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }
        [JsonProperty("destinationBankName")]
        public string? DestinationBankName { get; set; }
    }

    public class BulkTransferListResponse
    {
        [JsonProperty("content")]
        public TransferBulkResponse[]? Content { get; set; }
        [JsonProperty("pageable")]
        public Pageable? Pageable { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("sort")]
        public Sort? Sort { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }
    }


    public class SingleTransferListResponse
    {
        public SingleTransferStatusResponse[]? Content { get; set; }
        [JsonProperty("pageable")]
        public Pageable? Pageable { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("sort")]
        public Sort? Sort { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }
    }


    public class BulkTransferTransactionsResponse
    {
        [JsonProperty("content")]
        public SingleTransferStatusResponse[]? Content { get; set; }
        [JsonProperty("pageable")]
        public Pageable? Pageable { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("sort")]
        public Sort? Sort { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }
    }

    public class BulkTransferStatusRequest : BaseFilterRequest
    {
        [JsonProperty("bactchReference")]
        public string? BatchReference { get; set; }
    }
}