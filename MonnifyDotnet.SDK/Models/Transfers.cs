using Newtonsoft.Json;

namespace MonnifyDotnetSDK.src.Models
{
    public class InitiateTransferRequest
    {
        [JsonProperty("amount")]
        public required float Amount { get; set; }

        [JsonProperty("reference")]
        public required string Reference { get; set; }

        [JsonProperty("narration")]
        public required string Narration { get; set; }

        [JsonProperty("destinationBankCode")]
        public required string DestinationBankCode { get; set; }

        [JsonProperty("destinationAccountNumber")]
        public required string DestinationAccountNumber { get; set; }

        [JsonProperty("currency")]
        public required string Currency { get; set; }

        [JsonProperty("sourceAccountNumber")]
        public required string SourceAccountNumber { get; set; }
    }

    public class InitiateTransferAsyncTransfer : InitiateTransferRequest
    {
        [JsonProperty("async")]
        public bool Async { get; set; }
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
        public required string Reference { get; set; }
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
        public float amount { get; set; }
        public string? reference { get; set; }
        public string? narration { get; set; }
        public string? currency { get; set; }
        public float fee { get; set; }
        public bool twoFaEnabled { get; set; }
        public string? status { get; set; }
        public string? transactionDescription { get; set; }
        public string? transactionReference { get; set; }
        public DateTime createdOn { get; set; }
        public string? sourceAccountNumber { get; set; }
        public string? destinationAccountNumber { get; set; }
        public string? destinationAccountName { get; set; }
        public string? Message { get; set; }
        public string? destinationBankName { get; set; }
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