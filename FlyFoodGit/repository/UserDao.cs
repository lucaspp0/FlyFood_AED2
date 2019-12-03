using FlyFoodGit.models;
using FlyFoodGit.repository.Interface;
using FlyFoodGit.service;
using FlyFoodGit.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FlyFoodGit.models;

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
			List<User> users = select();
			foreach(User user in users){
				if(user.Id == id){
					return user;
				}
			}
			return null;
            // return select().Find( user => user.Id == id ); // encontrar um usuário com id especifico
        }

        public List<User> select()
        {
            try
            {
				List<User> users = new List<User>(); // cria lista vazia
				List<string> linhas = FileHelper.ReadFile(typeof(User)); // ler todas as linhas do arquivo
				foreach(string linha in linhas){ // percorre cada linha do arquivo
					User user = new User(linha.Split( FileHelper.CHAR_SEPARETOR) ); // transforma a linha do arquivo em novo usuario, separando por ;
					users.Add(user);
				}
				return users;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error em buscar Usuário \n" + "error: " + ex.Message);
                StartPage.typeToContinue();
                return new List<User>();
            }
        }

        public bool Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
