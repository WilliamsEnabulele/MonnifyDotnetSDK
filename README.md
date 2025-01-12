# Monnify .NET SDK

[![NuGet version](https://img.shields.io/nuget/v/MonnifyDotnetSDK)](https://www.nuget.org/packages/MonnifyDotnetSDK)

Monnify .NET SDK simplifies integration with the [Monnify API](https://developers.monnify.com/api/) for developers using .NET.

## Features

- Easy-to-use SDK for Monnify payments.
- Supports:
    - [x] CustomerReservedAccount
    - [x] DirectDebit
    - [x] Invoice
    - [x] LimitProfile
    - [x] Paycode
    - [x] RecurringPayment
    - [x] Refund
    - [x] Settlement
    - [x] SubAccount
    - [x] Transaction
    - [x] Transfer
    - [x] Verification
    - [x] Wallet
    - [x] Other

## Installation

Install the package via NuGet:

```bash
dotnet add package MonnifyDotnetSDK
```

## Configuration

Add your Monnify credentials in `appsettings.json`:

```json
{
  "Monnify": {
    "ApiKey": "YOUR_API_KEY",
    "SecretKey": "YOUR_SECRET_KEY",
    "BaseUrl": "https://sandbox.monnify.com/api/v1"
  }
}
```

## Usage

You can use in two ways, either register the SDK in your application:
### 1. Via Dependency Injection

```csharp
builder.Services.AddMonnify(options => 
{
    options.ApiKey = builder.Configuration["Monnify:ApiKey"];
    options.SecretKey = builder.Configuration["Monnify:SecretKey"];
    options.BaseUrl = builder.Configuration["Monnify:BaseUrl"];
});


public class PaymentService {
    private readonly IMonnifyClient _monnifyClient;

    PaymentService(IMonnifyClient monnifyClient) {
        _monnifyClient = monnifyClient;
    }

    public YourResponse InitiatePayment(Request request) {
        var response = _monnifyClient.Transaction.InitiateTransaction(request);
        ...
    }
}

```

### 2. or simply create a new instance of MonnifyClient

```csharp
var monnifyClient = new MonnifyClient(new MonnifyOptions
{
    ApiKey = "{{API-KEY}}",
    ApiSecret = "{{API-SECRET}}",
    BaseUrl = "{{BASE-URL}}"
})

var paymentRequest = new InitiatizeTransaction
{
    Amount = 5000.00m,
    CurrencyCode = "NGN",
    CustomerEmail = "customer@example.com",
    CustomerName = "John Doe",
    PaymentReference = "unique-payment-ref",
    PaymentDescription = "Test Payment",
    RedirectUrl = "https://your-site.com/payment-callback"
};


var response = await monnifyClient.Transaction.InitiateTransaction(paymentRequest);
...

```

## API Documentation

For detailed information about the Monnify API, refer to the [official documentation](https://docs.teamapt.com/docs/overview).

## License

This SDK is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
