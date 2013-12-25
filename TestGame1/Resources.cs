#region Using stuff
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
#endregion

namespace TestGame1
{
    class Resources
    {

        private static Dictionary<String, Texture2D> textureTable = new Dictionary<String, Texture2D>();

        private static ContentManager content;

        public static void setContentLoader(ContentManager c)
        {
            Resources.content = c;
        }

        public static Texture2D get(String txName)
        {
            if (textureTable.ContainsKey(txName)) return textureTable[txName];
            else return load(txName);
        }

        public static Texture2D load(String txName)
        {
            Texture2D temp = null;
            if (!textureTable.ContainsKey(txName))
            {
                temp = content.Load <Texture2D> (txName);
                textureTable.Add(txName, temp);
                return textureTable[txName];
            }
            return textureTable[txName];
        }

    }
}
