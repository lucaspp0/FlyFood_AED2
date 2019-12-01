using FlyFoodGit.models;
using FlyFoodGit.repository.Interface;
using FlyFoodGit.service;
using FlyFoodGit.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFoodGit.repository
{
    public class UserDao : IUserDao
    {

        public bool Create(User user)
        {
            return FileHelper.Append(user.serialize(), user.GetType() );
        }

        public bool Delete(User user)
        {
            throw new NotImplementedException();
        }

        public bool Insert(User user)
        {
            throw new NotImplementedException();
        }

        public User select(int id)
        {
            return select().Find( user => user.Id == id ); // encontrar um usuário com id especifico
        }

        public List<User> select()
        {
            try
            {
                // pegar cada linha do arquivo e criar um new user
                return (
                        from x in FileHelper.ReadFile(typeof(User))
                        select new User(x.Split(FileHelper.CHAR_SEPARETOR))
                    ).ToList<User>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error em buscar Usuário \n" + "error: " + ex.Message);
                StartPage.typeToStop();
                return new List<User>();
            }
        }

        public bool Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
