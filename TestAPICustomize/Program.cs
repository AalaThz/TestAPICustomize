using IdentityModel.Client;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.  
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "SamakplApi",
        Version = "v1",
        Description = "API for Authentication",
    });
    c.DescribeAllParametersInCamelCase();
    //c.MapType<TokenResponse>(() => new OpenApiSchema
    //{
    //    Type = "object",
    //    Properties =
    //    {
    //        ["success"] = new OpenApiSchema { Type = "boolean" },
    //        ["message"] = new OpenApiSchema { Type = "string" },
    //        ["data"] = new OpenApiSchema
    //        {
    //            Type = "object",
    //            Properties =
    //            {
    //                ["token"] = new OpenApiSchema { Type = "string" },
    //                ["expireDate"] = new OpenApiSchema { Type = "string" }
    //            }
    //        }
    //    }
    //});
});

var app = builder.Build();

// Configure the HTTP request pipeline.  
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "SamakplApi V1");
    //c.RoutePrefix = string.Empty; // Swagger UI at root  
});

app.MapControllers();

app.Run();