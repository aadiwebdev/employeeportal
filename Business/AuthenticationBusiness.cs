using Domain.Models;
using Repository;

namespace Business
{
    class AuthenticationBusiness
    {

        public bool ValidateLogin(LoginModel loginModel)
        {
            AuthenticationRepo authRepo = new AuthenticationRepo();
            return authRepo.ValidateLogin(loginModel);
        }
        public bool RegisterUser(RegistrationModel registrationModel)
        {
            AuthenticationRepo authRepo = new AuthenticationRepo();
            return authRepo.RegisterUser(registrationModel);
        }
    }
}
