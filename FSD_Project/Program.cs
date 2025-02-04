using FSD_Project.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FSD_Project.Data;
using FSD_Project.Components.Account;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using FSD_Project.Services;
using Microsoft.AspNetCore.Identity.UI.Services;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddDbContextFactory<FSD_ProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FSD_ProjectContext") ?? throw new InvalidOperationException("Connection string 'FSD_ProjectContext' not found.")));
builder.Logging.ClearProviders(); // Clear default providers
builder.Logging.AddConsole();    // Add console logging
builder.Logging.AddDebug();      // Add debug logging
builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddServerSideBlazor();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();

builder.Services.AddScoped<EmailService>();  // Register EmailService
builder.Services.AddScoped<IEmailSender<FSD_ProjectUser>, EmailSender>();


builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
    .AddIdentityCookies();
builder.Services.AddScoped<IReservationService, ReservationService>();
builder.Services.AddScoped<TableService>();

builder.Services.AddIdentityCore<FSD_ProjectUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<FSD_ProjectContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

//builder.Services.AddSingleton<IEmailSender<FSD_ProjectUser>, IdentityNoOpEmailSender>();

builder.Logging.ClearProviders(); // Optional: Clear default providers
builder.Logging.AddConsole();    // Add console logging
builder.Logging.AddDebug();      // Add debug logging


var app = builder.Build();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();



app.MapAdditionalIdentityEndpoints(); ;

app.Run();

app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

void ConfigureServices(IServiceCollection services)
{
    services.AddControllersWithViews();
    services.AddRazorPages();
}

builder.Services.AddSingleton<LoginStateService>();