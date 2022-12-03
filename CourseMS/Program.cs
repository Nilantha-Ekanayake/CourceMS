using Cource.Application;
using Cource.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json")
                            .Build();

builder.Services.AddDbContext<AcademicDBContext>(options => options.UseSqlServer(
       configuration["ConnectionStrings:DefaultConnection"], (obj) => obj.MigrationsAssembly("CourseMS"))

);

builder.Services.AddControllers();
builder.Services.AddScoped<IAcademicCourceService, AcademicCourceService>();
builder.Services.AddScoped<IAcademicCourceRepository, AcademicCourceRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

