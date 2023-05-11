using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_0511
{

    class Box
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        static float Width;
        static float Height;
        public float area(float w, float h)
        {
            return Width*Height;
        }
    }

}
