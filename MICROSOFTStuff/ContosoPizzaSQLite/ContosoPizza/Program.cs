using ContosoPizza.Services;
using ContosoPizza.Data;
using Microsoft.OpenApi.Models;

// https://docs.microsoft.com/en-us/learn/modules/improve-api-developer-experience-with-swagger/5-exercise-use-swagger-ui
using System.Reflection;
using System.IO;

// Additional using declarations

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Swagger to use OpenAPI
// Source: https://docs.microsoft.com/en-us/learn/modules/improve-api-developer-experience-with-swagger/3-exercise-enable-swagger-and-swashbuckle
//
builder.Services.AddSwaggerGen(options =>
    {
        options.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "Contoso Pizza API",
            Version = "v1",
            Description = "An ASP.NET Core Web API for managing Contoso Pizza items.",
            TermsOfService = new Uri("https://asp.net"),
            Contact = new OpenApiContact
            {
                Name = "Cassio Freitas",
                Url = new Uri("https://me.cassiofreitas.com.br")
            },
            License = new OpenApiLicense
            {
                Name = "Contoso Pizza API License",
                Url = new Uri("https://me.cassiofreitas.com.br")

            }
        });

        // using System.Reflection;
        var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
    }
);


// Add the PizzaContext
builder.Services.AddSqlite<PizzaContext>("Data Source=./Database/ContosoPizza.db");
// Add the PromotionsContext
builder.Services.AddSqlite<PromotionsContext>("Data Source=./Promotions/Promotions.db");

builder.Services.AddScoped<PizzaService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    // Source: https://docs.microsoft.com/en-us/learn/modules/improve-api-developer-experience-with-swagger/3-exercise-enable-swagger-and-swashbuckle
    app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Contoso Pizza API v1");
            c.InjectStylesheet("");
        }
    );
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Add the CreateDbIfNotExists method call
app.CreateDbIfNotExists();

app.Run();