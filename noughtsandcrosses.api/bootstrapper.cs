using Microsoft.AspNetCore.Server.Kestrel.Core;
using noughtsandcrosses.api.Repositories;
using noughtsandcrosses.api.Repositories.Interfaces;
using noughtsandcrosses.Server.Modules;
using Nancy;
using Nancy.TinyIoc;

namespace noughtsandcrosses.api
{
    public class Bootstrapper: DefaultNancyBootstrapper
    {
        private static KestrelServer _kestrelServer;

        public static void Initialize(TinyIoCContainer container)
        {
            container.Register<IDataContext, DataContext>().AsMultiInstance();
            container.Register<IBoardRepository, BoardRespository>().AsMultiInstance();
            container.Register<IGameRepository, GameRepository>().AsMultiInstance();
            container.Register<IPlayerRepository, PlayerRepository>().AsMultiInstance();
            container.Register<ISignUpRepository, SignUpRepository>().AsMultiInstance();
        }
    }
}
