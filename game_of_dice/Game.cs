using System;
using System.Collections.Generic;
using System.Linq;

namespace game_of_dice
{
    internal class Game
    {
        public void Game_s(int number_of_faces, int number_of_players)
        {
            Cube cube = new Cube(number_of_faces);
            var pers_res = new Dictionary<string, int>();
            //int[] arr = new int[number_of_faces];
            for (int i = 0; i < number_of_players; i++)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Введите имя игрока " + (i + 1) + ": ");

                string name_player = Console.ReadLine();

                int the_die_is_thrown = cube.Roll_the_dice();

                Player player = new Player(name_player, the_die_is_thrown);

                pers_res.Add(player.get_name(), player.get_rolled_number());
                var sortedDict = pers_res.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                string res_text = string.Join(", ", sortedDict);
                Console.WriteLine(res_text);
                Console.WriteLine("--------------------------------------------------");
                /* arr[i] = the_die_is_thrown;
                 int maxaValue = arr.OrderByDescending(x => x).First();
                 Console.WriteLine(player.get_result()+"\nНаибольшее: "+ maxaValue);
                 Console.WriteLine("--------------------------------------------------");*/
            }
        }
    }
}