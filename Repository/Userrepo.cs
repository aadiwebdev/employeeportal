using Domain.Enums;
using Domain.Models;
using System.Collections.Generic;
using System.Collections.;
using System.Linq;

namespace Repository
{
    class UserRepo
    {
        public List<UserModel> GetUserDetails(UserRoleChoice userRoleChoice)
        {
            List<UserModel> usersList=null;
            switch ((int)userRoleChoice)
            {
                case 1 :
                        usersList = (List<UserModel>)DataSource._userList.Where(m => m.isStudent == true);
                         break;
                case 2 :
                        usersList = (List<UserModel>)DataSource._userList.Where(m => m.isStudent == false);
                         break;
                case 3:
                    usersList = DataSource._userList;
                    break;
            }
            return usersList;
        }
    }
}
