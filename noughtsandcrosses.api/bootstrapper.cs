using Microsoft.AspNetCore.Server.Kestrel.Core;
using noughtsandcrosses.api.Repositories;
using noughtsandcrosses.api.Repositories.Interfaces;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace noughtsandcrosses.api
{
    public class Bootstrapper: DefaultNancyBootstrapper
    {
        private static KestrelServer _kestrelServer;

        public static void Initialize(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {
            container.Register<IDataContext, DataContext>().AsMultiInstance();
            container.Register<IGameRepository, GameRepository>().AsMultiInstance();
        }
    }
}
