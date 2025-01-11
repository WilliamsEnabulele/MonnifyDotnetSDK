# Monnify .NET SDK

[![NuGet version](https://img.shields.io/nuget/v/MonnifyDotnetSDK)](https://www.nuget.org/packages/MonnifyDotnetSDK)

Monnify .NET SDK simplifies integration with the [Monnify API](https://developers.monnify.com/api/) for developers using .NET.

## Features

- Easy-to-use SDK for Monnify payments.
- Supports card, bank transfer, reserved accounts, and split payments.

## Installation

Install the package via NuGet:

```bash
dotnet add package MonnifySDK
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

Register the SDK in your application:

```csharp
builder.Services.AddMonnify(options => 
{
    options.ApiKey = builder.Configuration["Monnify:ApiKey"];
    options.SecretKey = builder.Configuration["Monnify:SecretKey"];
    options.BaseUrl = builder.Configuration["Monnify:BaseUrl"];
});
```

## Usage

### 1. Initialize the Monnify Client

```csharp
var monnifyClient = serviceProvider.GetRequiredService<IMonnifyClient>();
```

### 2. Create a Payment Request

```csharp
var paymentRequest = new CreatePaymentRequest
{
    Amount = 5000.00m,
    CurrencyCode = "NGN",
    CustomerEmail = "customer@example.com",
    CustomerName = "John Doe",
    PaymentReference = "unique-payment-ref",
    PaymentDescription = "Test Payment",
    RedirectUrl = "https://your-site.com/payment-callback"
};

var response = await monnifyClient.Payments.CreatePaymentRequestAsync(paymentRequest);

if (response.IsSuccess)
{
    Console.WriteLine($"Payment URL: {response.Data.PaymentUrl}");
}
else
{
    Console.WriteLine($"Error: {response.ErrorMessage}");
}
```

### 3. Verify a Transaction

```csharp
var transactionStatus = await monnifyClient.Transactions.VerifyTransactionAsync("transaction-reference");

if (transactionStatus.IsSuccess)
{
    Console.WriteLine($"Transaction Status: {transactionStatus.Data.Status}");
}
else
{
    Console.WriteLine($"Error: {transactionStatus.ErrorMessage}");
}
```

### 4. Reserve an Account

```csharp
var reserveAccountRequest = new ReserveAccountRequest
{
    AccountName = "John Doe",
    CurrencyCode = "NGN",
    CustomerEmail = "customer@example.com",
    CustomerName = "John Doe",
    AccountReference = "unique-account-ref"
};

var response = await monnifyClient.Accounts.ReserveAccountAsync(reserveAccountRequest);

if (response.IsSuccess)
{
    Console.WriteLine($"Reserved Account: {response.Data.AccountNumber}");
}
else
{
    Console.WriteLine($"Error: {response.ErrorMessage}");
}
```

## API Documentation

For detailed information about the Monnify API, refer to the [official documentation](https://docs.teamapt.com/docs/overview).

## License

This SDK is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
