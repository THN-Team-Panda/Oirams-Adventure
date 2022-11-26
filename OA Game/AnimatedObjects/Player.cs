﻿using System.Windows.Media;
using GameEngine.GameObjects;

namespace OA_Game
{
    /// <summary>
    /// Represent the main character O'iram.
    /// </summary>
    public class Player : AnimatedObject
    {
        /// <summary>
        /// If the player gets damage he is for a short time invincible (can't get damage).
        /// </summary>
        public bool Invincible { get; }

        /// <summary>
        /// Is the amount of munition the player has to shoot.
        /// </summary>
        public int Munition { get; set; } = 0;

        /// <summary>
        /// Is a property for GameOver to check, if the level is over.
        /// </summary>
        public bool IsDead { get; set; }

        /// <summary>
        /// Represent the extra live.
        /// </summary>
        public bool HasHat { get; set; }

        /// <summary>
        /// Max amount of munition the player can carry.
        /// </summary>
        private const int MaxMunition = 10;

        /// <summary>
        /// Bool to Indicates if the Player can jump
        /// </summary>
        public bool CanJump { get; set; }

        public Player(int height, int width, ImageSource[] images, int initSprite = 0) : base(height, width, images, initSprite)
        {
        }

    }
}
