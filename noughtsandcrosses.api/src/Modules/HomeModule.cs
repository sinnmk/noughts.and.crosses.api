using Nancy;

namespace noughtsandcrosses.api.Modules
{
    public class HomeModule: NancyModule
    {
        public HomeModule() : base("home")
        {
            Get("/", args => "home" );
        }

    }
}
