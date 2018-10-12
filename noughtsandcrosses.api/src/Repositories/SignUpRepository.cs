using noughtsandcrosses.api.Repositories.Interfaces;
using noughtsandcrosses.Server.Repositories.Models;

namespace noughtsandcrosses.Server.Modules
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
