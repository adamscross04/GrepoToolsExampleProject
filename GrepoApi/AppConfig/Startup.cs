using System.Web.Http;
using Owin;
using Orleans;
using Orleans.Runtime.Configuration;
using Microsoft.Orleans.ServiceFabric;
using Orleans.Runtime;
using GrepoApi.AppConfig;
using DryIoc;
using System;
using DryIoc.WebApi;

namespace GrepoApi
{
    public static class Startup
    {


        private static IClusterClient BuildOrleansClient(System.Uri fabricName)
        {
            IClientBuilder clientBuilder = new ClientBuilder();
            clientBuilder.UseConfiguration(new ClientConfiguration());
            clientBuilder.AddServiceFabric(fabricName);
            clientBuilder.ConfigureServices(collection =>
            {
                // Add in Custom Services here
            });
            return clientBuilder.Build();
        }

        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public static void ConfigureApp(IAppBuilder app)
        {



            LogManager.LogConsumers.Add(new EventSourceLogger());

            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();

            var di = new Container();
            var serviceName = new Uri("fabric:/GrepoApp/GrepoSiloHost");


            var client = BuildOrleansClient(serviceName);

            do
            {
                try
                {
                    client.Connect().Wait();
                }
                catch (Exception e)
                {
                    ServiceEventSource.Current.Message(e.Message);
                    client = BuildOrleansClient(serviceName);
                    //throw;
                }


            } while (client.IsInitialized == false);




            di.UseInstance(client);

            // Register other services here.

            // NOTE: Registers ISession provider to work with injected Request
            //            di.Register(Made.Of(() => GetSession(Arg.Of<HttpRequestMessage>())));

            di.WithWebApi(config);

            app.UseWebApi(config);














        }
    }
}
