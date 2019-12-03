using FlyFoodGit.views;
using System;
using System.IO;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFoodGit.service
{
    public class FileHelper
    {
        public static char CHAR_SEPARETOR = ';';

        public static string getPath(string name)
        {
            return @"file" + Path.DirectorySeparatorChar + "database" + Path.DirectorySeparatorChar + name + ".txt";
        }

        public static void VerifyFile(string path)
        {
            if (!File.Exists(path)) // verifica se o arquivo existe
                File.Create(path); // cria arquivo
        }

        public static void WriteFile(string[] content, Type classType)
        {
            File.WriteAllLines(getPath(classType.Name), content); // escrevendo e sobrescrevendo um arquivo
        }

        public static Boolean Append(string content, Type classType)
        {
            try
            {
                VerifyFile(getPath(classType.Name));
                StreamWriter streamWriter = File.AppendText(getPath(classType.Name)); // preparar pra adicionar um texto no arquivo
                streamWriter.WriteLine(content); // escrevendo um texto no arquivo (adicionando e não sobrescrevendo)
                streamWriter.Close(); // fechando fluxo de dados
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: "+ex.Message);
                StartPage.typeToContinue();
                return false;
            }
        }
        
        public static List<string> ReadFile(Type classType)
        {
            VerifyFile(getPath(classType.Name));
            return  new List<string>(File.ReadAllLines(getPath(classType.Name)));
        }
    }
}
