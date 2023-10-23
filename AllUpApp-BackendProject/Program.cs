using AllUpApp_BackendProject;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
builder.Services.Register(config);

var app = builder.Build();
app.UseSession();


app.MapDefaultControllerRoute();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();

app.Run();