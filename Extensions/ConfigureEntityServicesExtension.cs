using ErrorProcessingWeb.Settings;
using SqlKata.Execution;
using SqlKata.Compilers;
using System.Data.SQLite;
using ErrorProcessingWeb.Services.Entity;

namespace ErrorProcessingWeb.Extensions;

public static class ConfigureEntityServicesExtension
{
    public static void ConfigureEntityServices(this IServiceCollection services, IConfiguration config)
    {
        var section = config.GetSection(nameof(EntitySettings));
        var settings = section.Get<EntitySettings>();

        //конфигурация работы с БД
        services.Configure<EntitySettings>(section);

        //настройка БД
        services.AddTransient<QueryFactory>(
            provider => {
                var db = new QueryFactory(
                    new SQLiteConnection(settings.ConnectionString),
                    new SqliteCompiler());

                db.Logger = compiled => Console.WriteLine(compiled.ToString());
                
                return db;
            }
        );

        //сервисы работы с БД
        services.AddTransient<HeroEntityService>();
        services.AddTransient<PowerEntityService>();
        services.AddTransient<StoryEntityService>();
        services.AddTransient<ParticipationEntityService>();
    }
}
