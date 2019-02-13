using Domain.Models;
using System.Linq;

namespace Repository
{
    public class AuthenticationRepo
    {
        public bool ValidateLogin(LoginModel loginModel)
        {
            return DataSource._userList.Any(m => m.EmailAddress == loginModel.EmailAddress && m.Password == loginModel.Password);
        }
        public bool RegisterUser(RegistrationModel registrationModel)
        {
            if (!DataSource._userList.Any(m => m.EmailAddress == registrationModel.EmailAddress))
            {
                UserModel userModel = new UserModel()
                {
                    FirstName = registrationModel.EmailAddress,
                    LastName = registrationModel.LastName,
                    EmailAddress = registrationModel.EmailAddress,
                    Password = registrationModel.Password,
                    ConfirmPassword = registrationModel.ConfirmPassword
                };
                DataSource._userList.Add(userModel);
            }
            return false;
        }
    }
}
