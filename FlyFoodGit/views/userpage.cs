using FlyFoodGit.controllers;
using FlyFoodGit.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFoodGit.views
{
    public class UserPage
    {

        private string options = @"
seleciona uma das opções:
    1) Abrir painel de Voos
    2) Comprar Voo
    3) Ver historico
    4) Sair
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
                        Flight.ShowPanel();
                        break;
                    case "2":
                        // FlightController.BuyTicket();
                        break;
                    case "3":
                        Program.userLogged.showHistory();
                        break;
                    case "4":
                        Console.WriteLine("Volte sempre :)");
                        Program.userLogged = null;
                        exitSystem = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        StartPage.typeToContinue();
                        break;
                }
            }
        }
    }
}
