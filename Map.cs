﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Map
    {

        public void Update()
        {

        }
        public void Draw()
        {
            for (int mapY = 0; mapY <= 30; mapY++)
            {
                Console.WriteLine("#");
                for (int mapX = 0; mapX < 40; mapX++)
                {
                    Console.Write("");
                }
            }


        }
    }
}
