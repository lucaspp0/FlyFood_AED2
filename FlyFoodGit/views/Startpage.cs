using FlyFoodGit.controllers;
using FlyFoodGit.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFoodGit.views
{
    class StartPage
    {
        /* UTILS */
        public static string getUserInput(string message = null)
        {
            if (message != null)
                Console.Write(message);
            return Console.ReadLine();
        }

        public static void typeToStop()
        {
            Console.WriteLine("digite algo para continuar: ");
            Console.ReadKey();
            Console.Clear();
        }

        private string options = @"
seleciona uma das opções:
    1) Login no sistema
    2) Cadastro no sistema
    3) Sair
opção: ";

        public void ShowMenu()
        {
            bool exitSystem = false;
            while (!exitSystem)
            {
                Console.Write(options);
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Login();
                        break;
                    case "2":
                        Register();
                        break;
                    case "3":
                        Console.WriteLine("Obrigado por usar o FlyFood");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }

        private void Login()
        {
            string login = getUserInput("insira o seu login: ");
            string password = getUserInput("insira a sua senha: ");
            User user = UserController.makeLogin(login: login, password: password);
            if (user == null)
                Console.WriteLine("Usuário não encontrado");
            else
                new UserPage().ShowMenu();
        }

        private void Register()
        {
            string login = getUserInput("Insira o seu login: ");
            string password = getUserInput("Insira a sua senha: ");
            string name = getUserInput("Insira seu nome: ");
            if (UserController.makeRegister(new User(name: name, login: login, password: password)))
                Console.WriteLine("Usuário Cadastrado com sucesso");
            else
                Console.WriteLine("Erro ao cadastrar usuário");

        }
    }
}