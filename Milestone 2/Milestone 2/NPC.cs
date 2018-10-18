using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Milestone_2
{
    class NPC
    {
        // attributes
        private int affection;
        private Texture2D texture;
        private Rectangle objectPos;

        // properties
        public int Affection
        {
            get
            {
                return affection;
            }
            set
            {
                affection = value;
            }
        }

        public Texture2D Texture
        {
            get
            {
                return texture;
            }
            set
            {
                texture = value;
            }
        }

        public Rectangle ObjectPos
        {
            get
            {
                return objectPos;
            }
            set
            {
                objectPos = value;
            }
        }

        public int XPos
        {
            get
            {
                return objectPos.X;
            }
            set
            {
                objectPos.X = value;
            }
        }

        public int YPos
        {
            get
            {
                return objectPos.Y;
            }
            set
            {
                objectPos.Y = value;
            }
        }

        // constructor
        public NPC(int x, int y, int width, int height)
        {
            x = objectPos.X;
            y = objectPos.Y;
            width = objectPos.Width;
            height = objectPos.Height;
        }

        // constructor
        public void Draw(SpriteBatch sBatch)
        {
            sBatch.Draw(Texture, ObjectPos, Color.White);
        }
    }
}
