using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorProcessingWeb.Services.DTO;

namespace ErrorProcessingWeb.Extensions;

public static class ConfigureDtoServiceExtension
{
    public static void ConfigureDtoServices(this IServiceCollection services)
    {
        services.AddTransient<HeroDtoService>();
        //...
    }
}
