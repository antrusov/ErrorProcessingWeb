using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorProcessingWeb.Services.VM.REST;

namespace ErrorProcessingWeb.Extensions;

public static class ConfigureVMServiceExtension
{
    public static void ConfigureVMServices(this IServiceCollection services)
    {
        services.AddTransient<HeroRestVMService>();
        services.AddTransient<PowerRestVMService>();
        services.AddTransient<StoryRestVMService>();
    }
}
