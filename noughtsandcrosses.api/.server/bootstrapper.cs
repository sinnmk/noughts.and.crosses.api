using Microsoft.AspNetCore.Server.Kestrel.Core;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using NoughtsAndCrosses.Server.Src.Repositories;
using NoughtsAndCrosses.Server.Src.Repositories.Interfaces;
using React;

namespace NoughtsAndCrosses.Server
{
    public class Bootstrapper: DefaultNancyBootstrapper
    {
        private static KestrelServer _kestrelServer;

        public static void Initialize(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {
            container.Register<IDataContext, DataContext>().AsMultiInstance();
            container.Register<IBoardRepository, BoardRespository>().AsMultiInstance();
            container.Register<IGameRepository, GameRepository>().AsMultiInstance();
            container.Register<IPlayerRepository, PlayerRepository>().AsMultiInstance();
        }
    }
}
