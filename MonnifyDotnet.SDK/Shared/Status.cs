namespace MonnifyDotnet.SDK.Shared
{
    public static class TransactionStatus
    {
        public const string Pending = "PENDING";
        public const string Overpaid = "OVERPAID";
        public const string PartiallyPaid = "PARTIALLY_PAID";
        public const string Paid = "PAID";
        public const string Expired = "EXPIRED";
        public const string Failed = "FAILED";
        public const string Cancelled = "CANCELLED";
    }

}