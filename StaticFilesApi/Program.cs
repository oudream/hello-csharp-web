using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// ���������Ҫ��ӷ��񣬱������ݿ���񣬿�����������ӣ�

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