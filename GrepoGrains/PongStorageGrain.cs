using GrepoTools.Distributed.GrainInterfaces;
using Orleans;
using Orleans.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrepoTools.Distributed.Grains
{
    [StorageProvider(ProviderName = "BlobStorage")]
    public class PongStorageGrain : Grain<PongHistoryModel>, IPongStorageGrain
    {
        async public Task<string> PongAsync(string value)
        {

            this.State.History.Add(value);
            await WriteStateAsync();

            return value.ToUpper();
        }
    }

    [Serializable]
    public class PongHistoryModel
    {
        public List<string> History { get; set; } = new List<string>();


    }
}

