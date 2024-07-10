using PimoBlazorWasmHostedTemplate.Server;
using PimoBlazorWasmHostedTemplate.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServer(builder.Host);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();
app.UseStatusCodePages();
app.MapHealthChecks("/healthz");
app.MapRazorPages();

#if UseControllers
app.MapControllers();
#else
app.MapGet(
    "/api/weather-forecasts/",
    () =>
        TypedResults.Ok<WeatherForecast[]>(
            [
                new()
                {
                    Date = new DateOnly(2022, 01, 06),
                    TemperatureC = 1,
                    Summary = "Freezing"
                },
                new()
                {
                    Date = new DateOnly(2022, 01, 07),
                    TemperatureC = 14,
                    Summary = "Bracing"
                },
                new()
                {
                    Date = new DateOnly(2022, 01, 08),
                    TemperatureC = -13,
                    Summary = "Freezing"
                },
                new()
                {
                    Date = new DateOnly(2022, 01, 09),
                    TemperatureC = -16,
                    Summary = "Balmy"
                },
                new()
                {
                    Date = new DateOnly(2022, 01, 10),
                    TemperatureC = -2,
                    Summary = "Chilly"
                }
            ]
        )
);
#endif

app.MapFallbackToFile("index.html");

app.Run();