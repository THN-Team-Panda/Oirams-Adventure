﻿using System;
using System.Collections.Generic;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.GameObjects
{
    public class AnimatedObject : DrawableObject
    {
        private ImageBrush[] sprites;

        private int currentSprite;

        public int SpritesCount
        {
            get { return sprites.Length; }
        }

        public int CurrentSprite
        {
            get { return currentSprite; }
        }

        public AnimatedObject(Rectangle mapObject, ImageSource[] sprites, int initSprite = 0) : base(mapObject)
        {
            // Copy Image Source array into the image brush
            this.sprites = new ImageBrush[sprites.Length];

            for (int i = 0; i < sprites.Length; i++)
                this.sprites[i].ImageSource = sprites[i];

            // Set the initSprite
            MapObject.Fill = this.sprites[initSprite];
        }

        public void SetSprite(int number)
        {
            currentSprite = number;
            MapObject.Fill = sprites[number];
        }
    }
}
