﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace OA_Game.AnimatedObjects
{
    public class KonkeyDong : Enemies
    {
        public KonkeyDong(Rectangle Rectangel, ImageSource[] images, int initSprite = 0) : base(Rectangel, images, initSprite)
        {
        }
    }
}
