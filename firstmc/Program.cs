using firstmc.Controllers;
using firstmc.Service;
using firstmc.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<AddTwoService>();
builder.Services.AddScoped<WakeUpService>();
builder.Services.AddScoped<CompareService>();
builder.Services.AddOpenApi();
  

var app = builder.Build();

app.MapControllers();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
app.UseSwagger();
app.UseSwaggerUI();}

app.UseHttpsRedirection();





app.Run();