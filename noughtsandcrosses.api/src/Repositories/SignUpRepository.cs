using noughtsandcrosses.api.Repositories.Interfaces;
using noughtsandcrosses.api.Repositories.Models;
using noughtsandcrosses.Server.Modules;

namespace noughtsandcrosses.api.Repositories
{
    public class SignUpRepository: ISignUpRepository
    {
        private readonly IDataContext _dataContext;

        public SignUp CreateSignUp(SignUp signup)
        {
//            var newSignUp = _dataContext.Signup.Add(signup);
            return new SignUp();
        }
    }
}
