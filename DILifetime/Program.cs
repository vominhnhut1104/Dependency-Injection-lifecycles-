using DILifetime.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
builder.Services.AddTransient<ITransientService, SomeService>();
builder.Services.AddScoped<IScopedService, SomeService>();
builder.Services.AddSingleton<ISingletonService, SomeService>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseMvc(routes =>
{
    //routes.MapRoute("secure", "secure", new
    //{
    //    Controller = "Admin",
    //    Action = "Index"
    //});

    //routes.MapRoute("default", "{controller=Home}/{action=Index}/{id:alpha:minlength(6)?}");
    routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
});
app.Run();
