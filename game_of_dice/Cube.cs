using System;

namespace game_of_dice
{
    internal class Cube
    {
        private int Number_of_faces;

        public Cube(int _Number_of_faces)
        {
            Number_of_faces = _Number_of_faces;
        }
       
        public int Roll_the_dice()
        {
            Random rando = new Random();
            int Res = rando.Next(1, Number_of_faces);

            return Res;
        }
    }
}