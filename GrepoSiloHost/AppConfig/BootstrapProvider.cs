using Orleans.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrepoSiloHost.AppConfig
{
    
    public class BootstrapProvider : IBootstrapProvider
    {
        public string Name { get; set; }

        public Task Close()
        {
            return Task.CompletedTask;
        }

        public Task Init(string name, IProviderRuntime providerRuntime, IProviderConfiguration config)
        {
            var logger = providerRuntime.GetLogger(nameof(BootstrapProvider));
            Name = name;
            return Task.FromResult(0);
        }
    }
}
