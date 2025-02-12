using CodeFirst.Controllers;
using CodeFirst.Data;
using CodeFirst.Data.Repositories;
using CodeFirst.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
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

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IWorkingExperienceRepository, WorkingExperienceRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<InsertUserWithExperiencesService>();
builder.Services.AddScoped<UpdateUserEmail>();
builder.Services.AddScoped<DeleteUserService>();    
builder.Services.AddControllers().AddJsonOptions(options=>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
 });
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
