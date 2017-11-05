using Orleans.Runtime;
using Orleans.Runtime.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrepoSiloHost.AppConfig
{
    public static class OrleansConfig
    {

        public static ClusterConfiguration GetClusterConfiguration()

        {
            LogManager.LogConsumers.Add(new EventSourceLogger());

            var config = new ClusterConfiguration();

            config.Globals.ReminderServiceType = GlobalConfiguration.ReminderServiceProviderType.AzureTable;
            config.Globals.DataConnectionStringForReminders = "UseDevelopmentStorage=true";

            config.Globals.DataConnectionString = "UseDevelopmentStorage=true";

            config.Globals.RegisterBootstrapProvider<BootstrapProvider>("booter");

            config.Defaults.StartupTypeName = typeof(ClusterStartup).AssemblyQualifiedName;

            // Used for setting up event sourcing.
            //config.AddStateStorageBasedLogConsistencyProvider("StateStorage");

            config.AddAzureBlobStorageProvider("BlobStorage");

 


            return config;
        }

    }
}
