using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using MiProyectoApi;
using Task_Managment.Domain;
using Task_Managment.Infrastructure;

public class Program
{
    //public static void Main(string[] args)
    //{
    //    CreateHostBuilder(args).Build().Run();
    //}

    //public static IHostBuilder CreateHostBuilder(string[] args) =>
    //    Host.CreateDefaultBuilder(args)
    //        .ConfigureWebHostDefaults(webBuilder =>
    //        {
    //            webBuilder.UseStartup<Startup>(); // Usa la clase Startup
    //        });


    public static void Main(string[] args)
    {
        var hostServer = CreateHostBuilder(args).Build();//.Run();
        using (var environment = hostServer.Services.CreateScope())
        {
            var services = environment.ServiceProvider;

            try
            {
                var userManager = services.GetRequiredService<UserManager<User>>();
                var context = services.GetRequiredService<DatabaseContext>();
                context.Database.Migrate();

                TestData.InsertData(context, userManager).Wait();
            }
            catch (Exception e)
            {
                var logging = services.GetRequiredService<ILogger<Program>>();
                logging.LogError(e, "Ocurrio un error en la migracion");
            }
        }

        hostServer.Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}





