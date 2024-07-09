using SdA.AFrodoJourney.Core.Interfaces.Businesses;
using SdA.AFrodoJourney.Core.Services.Businesses;
using SdA.AFrodoJourney.Core.Services.Infrastructures.Loggers;

var builder = WebApplication.CreateBuilder(args);

#region Injection de d�pendances
builder.Services.AddRazorPages();

// Une seule instance pour toute la vie de l'application
builder.Services.AddSingleton<SdA.AFrodoJourney.Core.Interfaces.Loggers.ILogger, ConsoleLogger>();

// L'instance existera tout le temps de la requ�te
builder.Services.AddScoped<IGetAllPeopleBusiness, SqlServerPeopleBusiness>();
builder.Services.AddScoped<IGetOneJourneyBusiness, InMemoryGetOneJourneyBusiness>();

// Transient : � chaque fois qu'on voit l'interface, il va instancier, donc ce n'est pas par requ�te


string valeur = builder.Configuration["ConnectionStrings:MaClefDaccess"];
string valeur2 = builder.Configuration["MaClef"];
string cs = builder.Configuration.GetConnectionString("MaClefDaccess");
#endregion

var app = builder.Build();

#region Middlewares
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
#endregion

#region Endpoints
app.MapRazorPages();
#endregion

app.Run();
