﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    abstract class GameCharacter : GameObject
    {
        public int health = 100; //protected, needs to be public to visibly test

        protected bool doAttack = false;
        protected bool canMove = true;
        protected bool isAlive = true;
        protected bool spawning = true;

        protected int minHealth = 0;
        protected int maxHealth; //set on a GameCharacter by GameCharacter basis

        public int initalizeStrength;
        public int priorPositionX;
        public int priorPositionY;
        public int deltaX;
        public int deltaY;

        public void TakeDamage(int atk) //has to be public
        {
            atk = Clamp(atk, 0, 1000);
            health = health - atk; //expand
            if (health <= 0) //This solves the death bug & health clamping, but I don't like how it does it.
            {
                health = Clamp(health, 0, 100);
                isAlive = false;
            }
        }

        protected void RespawnCharacter() //future use
        {

        }

        public void InitializeCharacterPosition(int initX, int initY) //once getter works, make coordinates only
        {
            initializeX = initX;
            initializeY = initY;
        }

        public void ApplyAction()
        {
            if (canMove) //enemy stops moving when attacked or if it attacks
            {
                x = x + deltaX;
                y = y + deltaY;

                x = Clamp(x, 0, 100);
                y = Clamp(y, 0, 100);
            }
        }

        public void Draw() //could move to GameObject class & apply to player & enemy
        {
            if (spawning) //needs to be changed
            {
                x = initializeX;
                y = initializeY;
                spawning = false;
            }
            if (isAlive)
            {
                if (objectIcon == '@') //bad
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition(x, y); //fix
                    Console.Write(objectIcon);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(x, y); //fix
                    Console.Write(objectIcon);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else if (!isAlive) //needs to be changed
            {
                x = 0;
                y = 0;
            }
        }
    }
}
