using System;

namespace Adivinhador
{
    class Program
    {
        public static void Main()
        {
            // Exercício com o C#
            // Gerar um número de 1 a 50 e pedir para o usuário adivinhar

            bool finishGame = false;
            while (finishGame == false)
            {
                Console.WriteLine("Olá! Vamos fazer uma partida de adivinhação.");
                Console.WriteLine("Diga um número entre 1 e 50:");
                Console.WriteLine("");

                int randomNumber = new Random().Next(1, 51);

                try
                {
                    int userNumber = Convert.ToInt32(Console.ReadLine());
                    bool isGuessInRange = userNumber <= 50&& userNumber > 0;
                    Console.WriteLine("");

                    if (!isGuessInRange)
                    {
                        Console.WriteLine("Epa, calma lá!");
                        Console.WriteLine("O número precisa estar entre 1 e 50!");
                    } else
                    {
                        if (userNumber != randomNumber)
                        {
                            Console.WriteLine("Que pena! Você errou.");
                            Console.WriteLine($"Você disse {userNumber}, porém o número era {randomNumber}");
                        }
                        else
                        {
                            Console.WriteLine("Uhu! É assim que se faz.");
                            Console.WriteLine($"O número realmente era {randomNumber}.");
                        }
                    }
                }
                catch (FormatException err)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ops, erro de formatação!");
                    Console.WriteLine("Você precisa digitar um número!");
                }
                catch (OverflowException err)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Número muito alto ou pequeno demais!");
                    Console.WriteLine("O valor precisa estar entre 1 e 50.");
                }

                string result = "";
                while (result != "s" && result != "n")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Deseja iniciar uma nova partida?");
                    Console.WriteLine("(S) Sim - (N) Não");
                    Console.WriteLine("");

                    string continueGame = Console.ReadLine().ToLower();
                    result = continueGame;

                    if (continueGame == "n")
                    {
                        finishGame = true;
                        Console.WriteLine("Entendi! Fechou então.");
                        Console.WriteLine("Bom jogo e te vejo na próxima.");
                    }

                    Console.WriteLine("");
                }
            }
        }
    }
}