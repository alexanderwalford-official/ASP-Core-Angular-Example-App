using Microsoft.EntityFrameworkCore;
using Training_App;

public class Program {
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

        // add services to the container.

        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            Console.WriteLine("DEV MODE");
        }

        app.UseStaticFiles();
        app.UseRouting();


        app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action=Index}/{id?}");

        Console.WriteLine("Mapped controllers!");

        app.MapFallbackToFile("index.html"); ;

        Console.WriteLine("Aplication now starting..");
        await app.RunAsync();
    }
}

