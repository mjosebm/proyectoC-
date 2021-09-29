using System;
using System.Collections.Generic;

namespace StrangleGame
{
    class Game

    {
        // Vamos a añadir las propiedades del juego ahorcado

        //Intentos permitidos
        public int Attemps { get; set; } //Por defecto 6

        //Palabra
        public string HideWord { get; set; }

        //Palabra oculta
        public string GameWordChardShow { get; set; }

        //Listas para el flujo del juego
        public List<char> InputCharsList { get; set; }

        public List<char> HideWordChars { get; set; }  // Se almacenan por defecto así "_"
        public List<char> CorrectChars { get; set; } // Aquí se guardan "a"

        public Game()
        {
            //Intentos por defecto 6
            Attemps = 6;

            //Añadimos palabra fija
            HideWord = "majito botero";

            //Convertir el string en un array de carácteres para aplicar las listas necesarias
            char[] charListElements = (HideWord.ToUpper()).ToCharArray();

            //Inicializar lista para los carácteres que vamos introduciendo.
            InputCharsList = new List<char>();

            HideWordChars = new List<char>(charListElements);

            CorrectChars = new List<char>(charListElements);

            for (int i = 0; i < HideWordChars.Count; i++)
            {
                if (HideWordChars[i] != ' ')
                {
                    HideWordChars[i] = '_';
                    GameWordChardShow += "_ ";
                }
                else
                {
                    GameWordChardShow += "  ";
                }
            }

            DrawGameImage();
            Console.WriteLine("Palabra a buscar: ");
            Console.WriteLine(GameWordChardShow);

        }



            private void DrawGameImage()
    {
        Console.WriteLine("====================");
        Console.WriteLine($"Intentos: {Attemps}");
        Console.WriteLine("====================");
        switch (Attemps)
        {
            case 6:
                Console.WriteLine(" ---------------------");
                for (int j = 0; j <= 15; j++)
                {
                    Console.WriteLine(" |");

                }
                Console.WriteLine("__________");
                break;

            case 5:
                Console.WriteLine(" ---------------------");
                Console.WriteLine(" |                     |");
                Console.WriteLine(" |                     |");
                Console.WriteLine(" |                  -------");
                Console.WriteLine(" |                 | o  -  |");
                Console.WriteLine(" |                 |   u   |");
                Console.WriteLine(" |                  -------");
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine(" |");

                }
                Console.WriteLine("__________");
                break;

            case 4:
                Console.WriteLine(" ---------------------");
                Console.WriteLine(" |                     |");
                Console.WriteLine(" |                     |");
                Console.WriteLine(" |                  -------");
                Console.WriteLine(" |                 | -  -  |");
                Console.WriteLine(" |                 |   U   |");
                Console.WriteLine(" |                  -------");
                Console.WriteLine(" |                     |   ");
                Console.WriteLine(" |                     |   ");
                Console.WriteLine(" |                     |   ");
                Console.WriteLine(" |                     |   ");
                Console.WriteLine(" |                     |   ");
                for (int j = 0; j <= 5; j++)
                {
                    Console.WriteLine(" |");

                }
                Console.WriteLine("__________");
                break;

            case 3:
                Console.WriteLine(" ---------------------");
                Console.WriteLine(" |                     |");
                Console.WriteLine(" |                     |");
                Console.WriteLine(" |                  -------");
                Console.WriteLine(" |                 | -  -  |");
                Console.WriteLine(" |                 |   U   |");
                Console.WriteLine(" |                  -------");
                Console.WriteLine(" |                     |   ");
                Console.WriteLine(" |                  /  |   ");
                Console.WriteLine(" |                 /   |   ");
                Console.WriteLine(" |                /    |   ");
                Console.WriteLine(" |                     |   ");
                for (int j = 0; j <= 5; j++)
                {
                    Console.WriteLine(" |");

                }
                Console.WriteLine("__________");
                break;

            case 2:
                Console.WriteLine(" ---------------------");
                Console.WriteLine(" |                     |");
                Console.WriteLine(" |                     |");
                Console.WriteLine(" |                  -------");
                Console.WriteLine(" |                 | -  -  |");
                Console.WriteLine(" |                 |   O   |");
                Console.WriteLine(" |                  -------");
                Console.WriteLine(" |                     |   ");
                Console.WriteLine(" |                   / | \\ ");
                Console.WriteLine(" |                  /  |  \\ ");
                Console.WriteLine(" |                 /   |   \\ ");
                Console.WriteLine(" |                     |   ");
                for (int j = 0; j <= 5; j++)
                {
                    Console.WriteLine(" |");

                }
                Console.WriteLine("__________");
                break;

            case 1:
                Console.WriteLine(" ---------------------");
                Console.WriteLine(" |                     |");
                Console.WriteLine(" |                     |");
                Console.WriteLine(" |                  -------");
                Console.WriteLine(" |                 | O  O  |");
                Console.WriteLine(" |                 |   _   |");
                Console.WriteLine(" |                  -------");
                Console.WriteLine(" |                     |   ");
                Console.WriteLine(" |                   / | \\ ");
                Console.WriteLine(" |                  /  |  \\ ");
                Console.WriteLine(" |                 /   |   \\ ");
                Console.WriteLine(" |                     |   ");
                Console.WriteLine(" |                    /  ");
                Console.WriteLine(" |                   /      ");
                Console.WriteLine(" |                  /       ");
                for (int j = 0; j <= 2; j++)
                {
                    Console.WriteLine(" |");

                }
                Console.WriteLine("__________");
                break;

            case 0:
                Console.WriteLine(" ---------------------");
                Console.WriteLine(" |                     |");
                Console.WriteLine(" |                     |");
                Console.WriteLine(" |                  -------");
                Console.WriteLine(" |                 | X  X  |");
                Console.WriteLine(" |                 |   o   |");
                Console.WriteLine(" |                  -------");
                Console.WriteLine(" |                     |   ");
                Console.WriteLine(" |                   / | \\ ");
                Console.WriteLine(" |                  /  |  \\ ");
                Console.WriteLine(" |                 /   |   \\ ");
                Console.WriteLine(" |                     |   ");
                Console.WriteLine(" |                    / \\");
                Console.WriteLine(" |                   /   \\  ");
                Console.WriteLine(" |                  /     \\ ");
                for (int j = 0; j <= 2; j++)
                {
                    Console.WriteLine(" |");

                }
                Console.WriteLine("__________");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"GAME OVER - La palabra era \"{HideWord}\"");
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }
    }
    }

}
