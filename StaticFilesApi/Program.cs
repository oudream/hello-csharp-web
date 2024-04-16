using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// （如果你需要添加服务，比如数据库服务，可以在这里添加）

var app = builder.Build();

// Serve static files from wwwroot
//app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")),
    RequestPath = "/static"
});

//app.UseAuthorization();

app.MapGet("/", () => "Hello World!");

app.Run();