using System.Collections.Generic;
using System.Linq;

namespace game_of_dice
{
    internal class Player
    {

        private string name;
        private int rolled_number;

        public Player(string _name, int _rolled_number)
        {
            name = _name;
            rolled_number = _rolled_number;           
        }        

       /* public string get_result()
        {
            return name +" : "+ rolled_number;
        }*/

        public string get_name()
        {
            return name;
        }
        public int get_rolled_number()
        {
            return rolled_number;
        }
    }
}