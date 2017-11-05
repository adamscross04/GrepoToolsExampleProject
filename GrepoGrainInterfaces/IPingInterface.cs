using Orleans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrepoTools.Distributed.GrainInterfaces
{
    public interface IPingGrain : IGrainWithGuidKey
    {

        Task<String> PongAsync(string value);
        

    }
}
