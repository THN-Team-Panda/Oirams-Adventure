﻿using GameEngine;
using GameEngine.GameObjects;
using System;
using System.Numerics;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace OA_Game.Enemies
{
    /// <summary>
    /// Skeleton is an enemy that walk around and try to hit the player if the player comes close to it.
    /// </summary>
    public class Skeleton : Enemie
    {
        /// <summary>
        /// property to check the damage output
        /// </summary>
        public override int Damage { get; } = 1;

        public override bool DirectionLeft { get ; set ; }

        public override void Move(Map map)
        {

            if(Is_Attacking)
                return;
            if (DirectionLeft)
            {
                Velocity = Velocity with { X = -1.4 };
                this.PlaySequenceAsync("move_skeleton", true, true);
            }
            else if (!DirectionLeft)
            {
                Velocity = Velocity with { X = +1.4 };
                this.PlaySequenceAsync("move_skeleton", false, true);
            }
            Velocity += Physics.Gravity;
            TileTypes[] collidedWithWhat = Physics.IsCollidingWithMap(map, this);
            if (collidedWithWhat[1] == TileTypes.Ground)
            {
                DirectionLeft = false;
            }
            else if (collidedWithWhat[3] == TileTypes.Ground)
            {
                DirectionLeft = true;
            }
            Position += Velocity;
            

        }

        public override void Attack()
        {
            PlaySequenceAsync("attack_skeleton", false, true);
        }


        public Skeleton(int height, int width, ImageSource defaultSprite) : base(height, width, defaultSprite)
        {
            DirectionLeft=true;
            PlayableSequence skeletonMove = new PlayableSequence(new ImageSource[]
            {
                new BitmapImage(Assets.GetUri("Images/Skeleton/Movement/Skeleton_Movement_1.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Movement/Skeleton_Movement_2.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Movement/Skeleton_Movement_3.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Movement/Skeleton_Movement_4.png"))
            });
            skeletonMove.Between = TimeSpan.FromMilliseconds(150);
            this.AddSequence("move_skeleton", skeletonMove);

            PlayableSequence skeletonAttack = new PlayableSequence(new ImageSource[]
            {
                new BitmapImage(Assets.GetUri("Images/Skeleton/Attack/Skeleton_Attacke_1.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Attack/Skeleton_Attacke_2.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Attack/Skeleton_Attacke_3.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Attack/Skeleton_Attacke_4.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Attack/Skeleton_Attacke_5.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Attack/Skeleton_Attacke_6.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Attack/Skeleton_Attacke_7.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Attack/Skeleton_Attacke_8.png"))
            });
            skeletonAttack.Between = TimeSpan.FromMilliseconds(150);
            this.AddSequence("attack_skeleton", skeletonAttack);

            PlayableSequence skeletonDying = new PlayableSequence(new ImageSource[]
            {
                new BitmapImage(Assets.GetUri("Images/Skeleton/Dying/Skeleton_Dying_1.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Dying/Skeleton_Dying_2.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Dying/Skeleton_Dying_3.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Dying/Skeleton_Dying_4.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Dying/Skeleton_Dying_5.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Dying/Skeleton_Dying_6.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Dying/Skeleton_Dying_7.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Dying/Skeleton_Dying_8.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Dying/Skeleton_Dying_9.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Dying/Skeleton_Dying_10.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Dying/Skeleton_Dying_11.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Dying/Skeleton_Dying_12.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Dying/Skeleton_Dying_13.png")),
                new BitmapImage(Assets.GetUri("Images/Skeleton/Dying/Skeleton_Dying_14.png"))

            });
            skeletonDying.Between = TimeSpan.FromMilliseconds(150);
            this.AddSequence("dying_skeleton", skeletonDying);
        }
    }
}
