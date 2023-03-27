using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Database Integration
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));


var app = builder.Build();
//Synfusion License Key
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTQ0MDI4N0AzMjMxMmUzMTJlMzMzNWtob3RPZkFKUVZlajVlUkN3SzlEU01oWUFPeUJuT2k2M05ONEtHZWdtZTg9;Mgo DSMBaFt QHFqVkNrX05HdkBAXWFKblJ0T2BRdVx1ZDU7a15RRnVfQV9gSHxQfkdmX35Wcw==;Mgo DSMBMAY9C3t2VFhhQlJBfVxdXmNWfFN0RnNYfVRzfF9EZUwxOX1dQl9gSX1RdURhWndcdXJWQGM=;Mgo DSMBPh8sVXJ1S0d X1RPdUBBXXxLflF1VWJbdV14fldDcDwsT3RfQF5jSnxQd0dgUX1bdnFXRQ==;MTQ0MDI5MUAzMjMxMmUzMTJlMzMzNWkyUW5BUnpiMUFZcHV6NldKbm1CNDdtRGphM0hSL2JVYWhuWHZFcytLZnM9;NRAiBiAaIQQuGjN/V0d XU9Hc1RBQmBJYVF2R2BJflx6d11MYllBJAtUQF1hSn5QdEZiW3xWcnFSQWNf;ORg4AjUWIQA/Gnt2VFhhQlJBfVxdXmNWfFN0RnNYfVRzfF9EZUwxOX1dQl9gSX1RdURhWndcdXxQRGQ=;MTQ0MDI5NEAzMjMxMmUzMTJlMzMzNVpXUFk5ZTl3c1BLRVQyK1Y3RXNmVGhRVjV4dVlQMk5KMFMrRkx0M3pPdEU9;MTQ0MDI5NUAzMjMxMmUzMTJlMzMzNUFaK2Mxa0c5Z1c5S2czNzZBYitKaXlBMk9KNy9mVUtyNHd4Z1o3UEF2bms9;MTQ0MDI5NkAzMjMxMmUzMTJlMzMzNUM5YXpub0JMQndMVzhjbERMYy9nNWJwSmtTNUVieGt4Y01tR2RJU2p1V009;MTQ0MDI5N0AzMjMxMmUzMTJlMzMzNUxGalZJK1poZXZtWGF5dmZhQmxMY3RmK3pKbkpmbFh0ekhLLzdVazdaWXc9;MTQ0MDI5OEAzMjMxMmUzMTJlMzMzNWtob3RPZkFKUVZlajVlUkN3SzlEU01oWUFPeUJuT2k2M05ONEtHZWdtZTg9");
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
