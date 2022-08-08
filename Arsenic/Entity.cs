using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenic
{
    public class Entity
    {

        public int health, team, lifestate, spotted;
        public float x, y, z, magnitude, xdist, headBoneX, headBoneY, headBoneZ;
        public Point  top, bottom;
        public Rectangle rect() // easier to access :)
        {
            return new Rectangle
            {
                Location = new Point(bottom.X - (bottom.Y - top.Y) / 4, top.Y),
                Size = new Size((bottom.Y - top.Y) / 2, (bottom.Y - top.Y))
            };
        }

    }

    public class Viewmatrix
    {
        public float

            m11, m12, m13, m14,
            m21, m22, m23, m24,
            m31, m32, m33, m34,
            m41, m42, m43, m44;
    }

}
