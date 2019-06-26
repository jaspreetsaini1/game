using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
namespace game
{
    internal class GenreateFire
    {
        Random rd = new Random();
        public int fire()
        {
            return rd.Next(3, 5);
        }

        public static implicit operator GenreateFire(Image v)
        {
            throw new NotImplementedException();
        }
    }
}