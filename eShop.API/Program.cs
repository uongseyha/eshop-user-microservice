using eShop.API.Middlewares;
using eShop.Core;
using eShop.Core.Mappers;
using eShop.Infrastructure;
using System.Text.Json.Serialization;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

//Add Infrastructure services
builder.Services.AddInfrastructure();
builder.Services.AddCore();

// Add controllers to the service collection
builder.Services.AddControllers().AddJsonOptions(options => {
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

//Fluent validation
builder.Services.AddFluentValidationAutoValidation();

builder.Services.AddAutoMapper(typeof(ApplicationUserMappingProfile).Assembly);

//Build the web application
var app = builder.Build();

app.UseExceptionHandlingMiddleware();

//Routing
app.UseRouting();

//Auth
app.UseAuthentication();
app.UseAuthorization();

//Controller routes
app.MapControllers();

app.Run();