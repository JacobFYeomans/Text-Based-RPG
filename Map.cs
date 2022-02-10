﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Map
    {
        private int x;
        private int y;

        public static char[,] mapArray = new char[,]//temp map also remember to create border
        {
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
            {'#',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',','#'},
            {'#',',',',',',',',',',',',',',',',',',','#','#','#','#','#','#','#','#','#','#',',',',',',',',',',',',',',',',',',',',','#'},
            {'#',',',',','#',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',','#',',',',',',',',',',',',',',',',',',',',',','},
            {'#',',','#',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',','#',',',',',',',',',',',',',',',',',',',',','#'},
            {'#',',',',','#',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',','#',',',',',',',',',',',',',',',',',',',',','#'},
            {'#',',',',',',','#',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',','#'},
            {'#',',',',','#',',',',',',',',','#','#','#',',',',',',',',',',',',',',',',',',',',',',','#',',',',',',',',',',',',',',','#'},
            {'#',',',',',',',',',',',',',',','#',',','#',',',',',',',',',',',',',',',',',',',',',',','#',',',',',',',',',',',',',',','#'},
            {'#',',',',',',',',',',',',',',','#','#','#',',',',',',',',',',',',',',',',',',',',',',','#',',',',',',',',',',',',',',','#'},
            {'#',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',','#',',',',',',',',',',',',',',','#'},
            {'#',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',','#',',',',',',',',',',',',',',','#'},
            {'#',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',','#',',',',',',',',',',',',',',','#'},
            {'#',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',','#',',',',',',',',',',',',',',','#'},
            {'#',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',','#'},
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
        };

        public void Update() //future use
        {
            
        }

        public void isWall(GameCharacter character) //future implementation
        {
            //if (Map.mapArray[y, x] == '#') //if I leave boundaries, it crashes because it's checking y and x vs map coordinates
            //{
            //    character.y = character.priorPositionY;
            //    character.x = character.priorPositionX;
            //}
        }

        public void Draw()
        {
            for (y = 0; y <= 15; y++)
            {
                for (x = 0; x <= 30; x++)
                {
                    ColourMap();
                    Console.Write(mapArray[y, x]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("");
            }
        }

        public void ColourMap()
        {
            if (mapArray[y, x] == '#')
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (mapArray[y, x] == ',')
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
    }
}
