using Carter;
using DengueManagement.API.APIClients.InfoDengue.GetEpidemiologicalDataByRJSP;
using DengueManagement.API.Configurations;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Refit;

var builder = WebApplication.CreateBuilder(args);

var assembly = typeof(Program).Assembly;
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(assembly);
    // config.AddOpenBehavior(typeof(ValidationBehavior<,>));
    // config.AddOpenBehavior(typeof(LoggingBehavior<,>));
});


builder.Services.AddCarter();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Dengue Management API",
        Description = "API de cliente do projeto Dengue Management",
    });
});


builder.Services.Configure<InfoDengueApiSettings>(builder.Configuration.GetSection("InfoDengueApiSettings"));
var infoDengueApiSettings =
    builder.Services.BuildServiceProvider().GetRequiredService<IOptions<InfoDengueApiSettings>>().Value ??
    throw new ArgumentNullException(
        "builder.Services.BuildServiceProvider().GetRequiredService<IOptions<InfoDengueApiSettings>>().Value");

builder.Services.AddRefitClient<IGetEpidemiologicalDataByRJSPFacade>()
               .ConfigureHttpClient(c => c.BaseAddress = new Uri(infoDengueApiSettings.BaseUrl!));


var app = builder.Build();



if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
{
    #region Swagger
    app.UseSwagger(c =>
    {
        c.SerializeAsV2 = true;
        c.RouteTemplate = "swagger/{documentName}/swagger.json";
        c.PreSerializeFilters.Add((swaggerDoc, httpReq) =>
        {
            swaggerDoc.Servers = new List<OpenApiServer> { new OpenApiServer { Url = $"https://{httpReq.Host.Value}" } };
        });
    });
    app.UseSwaggerUI();
    #endregion
}

#region MapCarter and Others pipelines
app.UseHttpsRedirection();
app.MapCarter();
#endregion

app.Run();