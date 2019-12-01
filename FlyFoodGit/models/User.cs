using FlyFoodGit.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFoodGit.models
{
    public enum Permission
    {
        ADMINISTRADOR,
        CLIENTE
    }

    public class User
    {

        public int Id { get; set; }
        public Permission PermissionUser { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User()
        {

        }

        public User(string name, string login, string password, Permission permission = Permission.CLIENTE)
        {
            this.Name = name;
            this.Login = login;
            this.Password = password;
            this.PermissionUser = permission;
        }

        public User(string[] serialized)
        {
            deserialize(serialized);
        }

        public string serialize()
        {
            return Id + FileHelper.CHAR_SEPARETOR + PermissionUser + FileHelper.CHAR_SEPARETOR + Name + FileHelper.CHAR_SEPARETOR + Login + FileHelper.CHAR_SEPARETOR + Password;
        }
        private void deserialize(string[] text)
        {
            try
            {
                this.Id = int.Parse(text[0].Trim());
                this.PermissionUser = (Permission) int.Parse(text[1].Trim());
                this.Name = text[2].Trim();
                this.Login = text[3].Trim();
                this.Password = text[4].Trim();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void showHistory()
        {
            /// TO DO
            throw new NotImplementedException();
        }
    }
}
