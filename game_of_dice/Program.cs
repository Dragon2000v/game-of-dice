using System;
using System.Collections.Generic;
using System.Linq;

namespace game_of_dice
{
    class Program
    {
        static void Main(string[] args)
        {
            string number_of_playerss, number_of_facess;
            while (true)
            {
                Console.Write("Введите количество игроков: ");
                number_of_playerss = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Введите количество граней кубика: ");
                number_of_facess = Console.ReadLine();
                if (int.TryParse(number_of_playerss,out int number_of_players)&&int.TryParse(number_of_facess,out int number_of_faces))
                {
                    var game = new Game();
                    game.Game_s(number_of_faces, number_of_players);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                }

            }
                
        }
      
    }

}
