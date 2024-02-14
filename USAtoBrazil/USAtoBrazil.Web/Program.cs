using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(options => {
    options.DefaultScheme = "Cookies";
    options.DefaultChallengeScheme = "oidc";
}).AddCookie("Cookies", c => c.ExpireTimeSpan = TimeSpan.FromMinutes(10))
.AddOpenIdConnect("oidc", options =>
{
    //options.Configuration = new OpenIdConnectConfiguration();
    //options.RequireHttpsMetadata = false;
    options.Authority = builder.Configuration["ServiceUrls:IdentityAPI"];
    options.GetClaimsFromUserInfoEndpoint = true;
    options.ClientId = "usatobraziladmin";
    options.ClientSecret = "secret";
    options.ResponseType = "code";

    //options.RequireHttpsMetadata = false;

    options.TokenValidationParameters.NameClaimType = "name";
    options.TokenValidationParameters.RoleClaimType = "role";
    options.Scope.Add("usatobraziladmin");
    options.SaveTokens = true;
    //options.MetadataAddress = "https://localhost:5093/.well-known/openid-configuration";

});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
