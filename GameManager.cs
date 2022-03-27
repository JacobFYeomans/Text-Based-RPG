﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class GameManager
    {
        //declaration & instantiation
        static Map map = new Map();
        static Player player = new Player();
        static EnemyManager enemyManager = new EnemyManager(map);
        static ItemManager itemManager = new ItemManager(map);
        static GameStateManager gameStateManager = new GameStateManager();
        static HUD hud = new HUD();

        public void gameLoop()
        {
            //game loop
            while (!gameStateManager.isGameLost(player) && !gameStateManager.isGameWon(enemyManager))
            {
                map.Draw();
                itemManager.DrawItems(); 
                player.Draw(); //redo map colour method
                enemyManager.DrawEnemies(); //camera!!, GlobalSettings settup
                
                map.Update();
                itemManager.UpdateItems(player);
                hud.DrawHUD(player, enemyManager);
                player.Update(map, enemyManager);
                enemyManager.UpdateEnemies(map, player, enemyManager);
            }

            if (gameStateManager.isGameLost(player))
            {
                gameStateManager.GameOverMessage();
            }
            else if (gameStateManager.isGameWon(enemyManager))
            {
                gameStateManager.GameWinMessage();
            }
            else
            {
                Console.WriteLine("GameState Error.");
            }

            Console.ReadKey(true);
        }

    }
}
