using GrepoTools.Distributed.GrainInterfaces;
using Orleans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace GrepoApi.Controllers
{
    /// <summary>
    /// A test controller for testing the connection is up and running.
    /// </summary>
    [RoutePrefix("api/ping")]
    public class PingPongController : ApiController
    {
        public PingPongController(IClusterClient client)
        {
            Client = client;
        }

        private IClusterClient Client { get; }

        /// <summary>
        /// Connects to Orleans and returns some text.
        /// </summary>
        /// <param name="text">Input Text</param>
        /// <returns>Output Text</returns>
        [Route("pong/{text}")]
        [HttpGet]
        public async Task<String> Pong(String text)
        {
            var g = Client.GetGrain<IPingGrain>(Guid.Empty);
            return await g.PongAsync(text);
        }
        [Route("pong/store/{text}")]
        [HttpGet]
        public async Task<String> StorePong(String text)
        {
            var g = Client.GetGrain<IPongStorageGrain>(Guid.Empty);
            return await g.PongAsync(text);
        }



    }
}
