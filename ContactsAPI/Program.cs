using ContactsAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
// using ContactsAPIDBcontext;

var builder = WebApplication.CreateBuilder(args);
//this is the starting point of our App.
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<ContactsAPIDBcontext>(options => options.UseInMemoryDatabase("ContactsDb"));
builder.Services.AddDbContext<ContactsAPIDBcontext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("ContactsApiConnectionString")));


var app = builder.Build();
//we are building this service here

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
