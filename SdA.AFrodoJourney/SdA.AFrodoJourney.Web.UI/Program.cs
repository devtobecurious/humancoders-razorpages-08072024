using SdA.AFrodoJourney.Core.Interfaces.Businesses;
using SdA.AFrodoJourney.Core.Services.Businesses;

var builder = WebApplication.CreateBuilder(args);

#region Injection de dépendances
builder.Services.AddRazorPages();
builder.Services.AddScoped<IGetAllPeopleBusiness, InMemoryGetAllPeopleBusiness>();
builder.Services.AddScoped<IGetOneJourneyBusiness, InMemoryGetOneJourneyBusiness>();
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
