var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.UseEndpoints(endpoins =>
{
    endpoins.MapControllers();
});

app.Run();
