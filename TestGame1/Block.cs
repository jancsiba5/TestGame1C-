using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestGame1
{
    class Block
    {
        private string texture;
        private bool solid;
        public string Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        public bool Solid
        {
            get { return solid; }
            set { solid = value; }
        }

        static enum BlockType
        {}

    }
}
