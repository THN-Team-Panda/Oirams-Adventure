﻿using GameEngine;
using System.Windows.Media;

namespace OA_Game.Enemies
{
    /// <summary>
    /// KonkeyDong is an enemy that jumps around his jukebox and try to hit the player if he comes close.
    /// </summary>
    public class KonkeyDong : Enemie
    {
        /// <summary>
        /// property to check the damage output
        /// </summary>
        public override int Damage { get; } = 2;

        public override bool DirectionLeft { get; set; }

        public override void Attack()
        {
            this.PlaySequenceAsync("attack_skeleton", false, true);
        }

        public override void Move(Map map)
        {
            throw new System.NotImplementedException();
        }

        public KonkeyDong(int height, int width, ImageSource defaultSprite) : base(height, width, defaultSprite)
        {
        }
    }
}
