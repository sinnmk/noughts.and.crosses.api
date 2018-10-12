using Nancy;

namespace noughtsandcrosses.Server.Modules
{
    public class SignUpModule: NancyModule
    {
        public SignUpModule(ISignUpLogic signUpLogic): base("signup")
        {
            Before += ctx => CheckAccess();
            Get("/", parameters => signUpLogic.GetSignUp());
        }

        private Response CheckAccess()
        {
            return null;
        }
    }
}
