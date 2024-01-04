using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");


builder.Services.AddControllers();
builder.Services.AddDbContext<StudyLibrary.DataAccess.StudyContext>(options =>
                options.UseSqlServer(connectionString));

var app = builder.Build();

app.UseEndpoints(endpoins =>
{
    endpoins.MapControllers();
});

app.Run();
