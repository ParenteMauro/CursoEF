using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen(c =>         
{
    c.SwaggerDoc("v1", new()
    {
        Title = "Mi API",
        Version = "v1"
    });
});

builder.Services.AddDbContext<CursoEfContext>(optionsAction: 
    options=> options.UseSqlServer(builder.Configuration.GetConnectionString("connectionDB")));
builder.Services.AddControllers();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    CursoEfContext context = scope.ServiceProvider.GetRequiredService<CursoEfContext>();    
    //context.Database.EnsureCreated();
    context.Database.Migrate();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseSwagger();                          
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mi API v1"); 
});


app.UseAuthorization();


app.MapControllers();
app.Run();
