using FlyFoodGit.models;
using FlyFoodGit.repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFoodGit.controllers
{
    public class UserController
    {

        public static IUserDao _userDao;

        public static User makeLogin(string login, string password)
        {
            // To Do
            throw new Exception("TO DO");
            // verificar se existe algum usuario com email e senha
        }

        public static bool makeRegister(User user)
        {
            // To Do
            throw new Exception("TO DO");
            // verificar se existe algum usuario com email e senha
        }
    }
}
