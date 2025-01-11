namespace MonnifyDotnetSDK.src.Models
{

    public class BankResponse
    {
        public string? name { get; set; }
        public string? code { get; set; }
        public object? ussdTemplate { get; set; }
        public object? baseUssdCode { get; set; }
        public object? transferUssdTemplate { get; set; }
    }

}