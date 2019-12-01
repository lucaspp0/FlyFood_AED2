using FlyFoodGit.controllers;
using FlyFoodGit.models;
using FlyFoodGit.repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFoodGit
{
    class Program
    {
        public static void InjectInterfaces()
        {
            UserController._userDao = new UserDao();
        }

        public static User userLogged;

        static void Main(string[] args)
        {
            InjectInterfaces();
            new views.StartPage().ShowMenu();
        }
    }
}
