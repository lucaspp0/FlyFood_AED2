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

        public static User Login(string login, string password)
        {
            // To Do
            throw new Exception("TO DO");
            // verificar se existe algum usuario com email e senha

            List<user> users = _userDao.select(); // pega toso os usuários
            foreach(user user in users){  // percorre cada usuário
                if( user.login == login && user.Passwrod == password ){ // verifica a senha e o login do usuário
                    return user; // retorna esse usuário
                }
            }
            return null;
        }

        public static bool Register(User user)
        {
            // To Do
            throw new Exception("TO DO");
            // verificar se existe algum usuario com email e senha
        }
    }
}
