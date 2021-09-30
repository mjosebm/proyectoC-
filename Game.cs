using System;
using System.Collections.Generic;
using System.IO;

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
            HideWord = GetHideWord();

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

        public void play()
        {
            //Mientras jugamos
            while (Attemps > 0 && HideWordChars.Contains('_'))
            {
                //Introducir el carácter desde la consola con el teclado
                char inputChar = ' ';
                Console.Write("\nIntroduzca la letra: ");
                try
                {
                    inputChar = Console.ReadLine().ToUpper()[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Hey! Recuerda escribir algo");
                    inputChar = '.';

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                }

                //Comprobar que es un caracter válido
                if (inputChar >= 'A' && inputChar <= 'Z')
                {
                    //CARÁCTER VÁLIDO

                    //Comprobar si el carácter se ha introducido
                    if (!InputCharsList.Contains(inputChar))
                    {
                        Console.Clear();
                        InputCharsList.Add(inputChar);
                        //Comprobar si existe en la palabra ocula

                        CheckExistCharInWord(inputChar);
                        //Dibujar el estado dependiendo del resultado anterior
                        DrawGameImage();

                        //Palabra a buscar
                        Console.WriteLine("Palabra a buscar: ");
                        Console.WriteLine(GameWordChardShow);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("¡Oops! Ya has introducido la letra '{0}'. Intenta de nuevo :D", inputChar);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }
            }

            //Partida Finalizada
            if (Attemps == 0)
            {
                DrawGameImage();
            }
            else if (!HideWordChars.Contains('_'))
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("¡Felicidades! Has ganado");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private List<string> LoadWordChars () {
            string loadText = File.ReadAllText(@"data/sagas-miticas.txt");
            string[] words = loadText.Split("\n");
            return new List<string>(words);

        }

        private string GetHideWord() {
            List<string> hideWords = LoadWordChars();
            Random random = new Random();
            int numberRandom = random.Next(0, hideWords.Count);
            return hideWords[numberRandom];
        }
        
        private void CheckExistCharInWord(char inputChar)
        {
            if (CorrectChars.Contains(inputChar))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("¡Genial! Has acertado una letra :) ");
                Console.ForegroundColor = ConsoleColor.White;
                GameWordChardShow = "";
                for (int i = 0; i < HideWordChars.Count; i++)
                {
                    if (CorrectChars[i] == inputChar)
                    {
                        HideWordChars[i] = inputChar;
                    }
                    GameWordChardShow += (HideWordChars[i] != ' ') ? HideWordChars[i] + " " : "   ";
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Oh no! Has perdido un intento :( ");
                Console.ForegroundColor = ConsoleColor.White;
                Attemps--;
            }
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
