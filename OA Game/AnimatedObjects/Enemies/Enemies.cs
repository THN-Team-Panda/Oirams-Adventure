﻿using System.Windows.Media;
using GameEngine.GameObjects;

namespace OA_Game.Enemies
{
    /// <summary>
    /// Class Enemies is the parent class for FliegeVieh, KonkeyDong, Skeleton. 
    /// </summary>
    public class Enemies : AnimatedObject
    {
        public int damage;
        public Enemies(int height, int width, ImageSource defaultSprite) : base(height, width, defaultSprite)
        {
        }
    }
}
