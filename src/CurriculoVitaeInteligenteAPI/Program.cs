using CurriculoVitaeInteligenteAPI.Configuration;
using CurriculoVitaeInteligenteDomain.Constant.settings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.ConfigurationPostgres(builder.Configuration);
builder.Services.AddDependencyInjectionConfiguration(builder.Configuration);
builder.Services.AddSwaggerConfiguration(builder.Configuration);
builder.Services.ConfiguratonsApi();
builder.Services.AutoMapperConfiguration();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.ConfigurationPostgresEscopo();
app.UseAuthentication();
app.UseAuthorization();
app.UseSwaggerConfiguration();
app.UseConfiguratonsApi();


app.MapRazorPages();

app.Urls.Add("http://*:5071");
app.Urls.Add("https://*:5070");

app.Run();
