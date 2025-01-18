using MonnifyDotnet.SDK.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMonnify(options =>
{
    options.ApiKey = "MK_TEST_5F5JLAUZKV";
    options.ApiSecret = "5470BV5JC8SXNB6N0V1ZMDK7BBAS6G0H";
    options.BaseUrl = "https://sandbox.monnify.com/api/";
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
