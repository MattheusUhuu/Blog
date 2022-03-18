using Blog.Data;

var builder = WebApplication.CreateBuilder(args);
ConfigureMvc(builder);
ConfigureServices(builder);

var app = builder.Build();
app.MapControllers();
app.Run();

void ConfigureMvc(WebApplicationBuilder builder)
{
    builder.Services.AddControllers();
}

void ConfigureServices(WebApplicationBuilder builder)
{
    builder.Services.AddDbContext<BlogDataContext>();
}
