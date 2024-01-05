using Business;
using Core.CrossCuttingConcerns.Exceptions.Extensions;
using Core.CrossCuttingConcerns.Logging.SeriLog;
using Core.CrossCuttingConcerns.Logging.SeriLog.Logger;
using DataAccess;
using Serilog;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers()
        .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler =
            ReferenceHandler.IgnoreCycles;
        });
builder.Services.AddBusinessServices();
builder.Services.AddDataAccessServices(builder.Configuration);

#region Logger-Service
builder.Services.AddTransient<MsSqlLogger>();
builder.Services.AddTransient<FileLogger>();
builder.Services.AddSingleton(Log.Logger);
#endregion

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
app.ConfigureCustomExceptionMiddleware();

app.UseAuthorization();

app.MapControllers();

app.Run();