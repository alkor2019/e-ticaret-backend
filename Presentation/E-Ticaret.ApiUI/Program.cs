using E_Ticaret.Application;
using E_Ticaret.Application.Validators.Products;
using E_Ticaret.Infrastructure;
using E_Ticaret.Infrastructure.Filters;
using E_Ticaret.Infrastructure.Services.Storage.Local;
using E_Ticaret.Persistence;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddPersistenceServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddApplicationServices();

builder.Services.AddStorage<LocalStorage>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
  policy.WithOrigins("https://mrayal-potential-guacamole-jxv697j77qrc54pg-4200.preview.app.github.dev").AllowAnyHeader().AllowAnyMethod()
));

builder.Services.AddControllers(options =>
{
    options.Filters.Add<ValidationFilter>();
})
    .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<CreateProductValidator>())
    .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
