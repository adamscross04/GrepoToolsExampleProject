using GrepoTools.Distributed.GrainInterfaces;
using Orleans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrepoTools.Distributed.Grains
{
    public class PingGrain : Grain, IPingGrain
    {
        async public Task<string> PongAsync(string value)
        {
            return value.ToUpper();
        }
    }
}
