using AutoMapper;
using ErrorProcessingWeb.Extensions;

//builder
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureEntityServices(builder.Configuration);
builder.Services.ConfigureDtoServices();
builder.Services.ConfigureVMServices();
builder.Services.AddLogging(configure => configure.AddConsole());
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//app
var app = builder.Build();
app.UseCustomExceptionHandler();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
