using FlyFoodGit.controllers;
using FlyFoodGit.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFoodGit.views
{
    public class AdmPage
    {
        private string options = @"
seleciona uma das opções:
    1) Register Flight
    2) Register snack
    3) Show Flighs
    4) Show Flighs
    5) Sair
opção: ";

        private void getDataForRegisterFlight()
        {
            string company = StartPage.getUserInput("Insira a compania aerea: ");
            string departure = StartPage.getUserInput("Insira o local final do Voo: ");
            string arrival = StartPage.getUserInput("Insira o local de partida do Voo: ");
            string derpatureTime = StartPage.getUserInput("Insira quando o Voo irá partir: ");
            if (FlightController.register(
                new Flight(company: company, departure: departure, arrival: arrival, departureTime: derpatureTime)
                ))
                Console.WriteLine("Voo cadastrado com sucesso");
            else
                Console.WriteLine("Erro ao cadastrar voo");
        }

        private void getDataForRegisterSnack()
        {
            // TO DO
        }

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
                        getDataForRegisterFlight();
                        break;
                    case "2":
                        getDataForRegisterSnack();
                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":
                        Console.WriteLine("Volte sempre :)");
                        Program.userLogged = null;
                        exitSystem = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        StartPage.typeToContinue();
                        break;
                }
                StartPage.typeToContinue();
            }
        }
    }
}
