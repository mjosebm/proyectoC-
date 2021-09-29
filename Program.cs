using System;

namespace StrangleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue = "";
            do
            {
                //Vamos a cambiar el color
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("====================JUEGO AHORCADO EN CONSOLA====================");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("Opciones del juego: ");
                Console.WriteLine("1) Nueva Partida");
                Console.WriteLine("2) Mostrar información del autor");
                Console.WriteLine("X) Salir del juego");
                Console.WriteLine("");
                Console.Write("Tu opción es: ");
                inputValue = Console.ReadLine();
                inputValue = inputValue.ToUpper();
                Console.WriteLine("");

                switch (inputValue)
                {
                    case "1":
                        Console.WriteLine("Vamos a jugar");
                        Game game = new Game();
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("=======Información del Autor=======");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Mariajosé Botero Martínez");
                        Console.WriteLine("mjoseb@summit.com.co");
                        break;
                    case "X":
                        Console.WriteLine("Salimos");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Opción no válida, por favor inténtelo de nuevo :)");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        inputValue = "invalido";
                        break;

                }

            }
            while (inputValue == "invalido");


        }
    }
}
