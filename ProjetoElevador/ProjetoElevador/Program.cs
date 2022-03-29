using System;
using System.IO;
using System.Threading;


using ProjetoElevador.Model;


namespace ProjetoElevador

{
    internal class Program
    {
        static void Main(String[] args)
        {

            ELEVADOR UPDOWN = new ELEVADOR();
            int CAP = 0;
            int TOTAND = 0;
            //int comando = 0;


            Console.WriteLine("Elevador estará em operação");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Definindo a Capacidade do elevador");
            CAP = int.Parse(Console.ReadLine());
            Console.WriteLine("Definir Total de Andares do Edificio");
            TOTAND = int.Parse(Console.ReadLine());

            UPDOWN.Inicializar(CAP, TOTAND);
            Console.Clear();

            bool cont = true;

            //faça
            do
            {
                Console.WriteLine(@" Escolha uma opção:
                                     1 - Entrando
                                     2 - Saindo
                                     3 - Subindo
                                     4 - Descendo
                                     5 - Sair");

                string select = Console.ReadLine();
                Console.Clear();

                switch (select)
                {
                    case "1":
                        Console.WriteLine("Entrar");
                        UPDOWN.Entrar();
                        break;
                    case "2":
                        Console.WriteLine("Sair");
                        UPDOWN.Sair();
                        break;
                    case "3":
                        Console.WriteLine("Subir");
                        UPDOWN.Subir();
                        break;
                    case "4":
                        UPDOWN.Descer();
                        Console.WriteLine("Descer");
                        break;
                    case "5":
                        cont = false;
                        break;

                    default:
                        Console.WriteLine("Escolha inválida.");
                        break;
                }
            }

            while (cont); //Enquanto for verdadeiro ira fazer.          


        }
    }
}