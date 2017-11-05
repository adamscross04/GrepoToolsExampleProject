
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Orleans.ServiceFabric;
using Microsoft.ServiceFabric.Services.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrepoSiloHost.AppConfig
{
    public class ClusterStartup
    {
        public static StatelessService Service
        {
            get;set;
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // Register any dependencies to be injected

            

            services.AddServiceFabricSupport(Service);
            return services.BuildServiceProvider();

        }
    }
}
