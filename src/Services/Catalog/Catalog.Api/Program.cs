var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblyContaining<Program>();
});
var app = builder.Build();
// Configure the HTTP request pipeline.
app.MapCarter();
app.Run();
