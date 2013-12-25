using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

/**
 * AUTHOR: jancsiba5
 * 
 */

namespace TestGame1
{
    public abstract class Entity
    {

        // Entity szuperosztály minden élő dologhoz a játékban
        // Ilyen lesz az ellenség, a Player meg ilyesmi

        public Vector2 position;
        public string textureName;
        public int health, armor;
        public float speed;

        public Entity(float x, float y, int health, int armor, float speed, string textureName)
        {

            this.position = new Vector2(x, y);
            this.health = health;
            this.armor = armor;
            this.speed = speed;
            this.textureName = textureName;

        }

    }
}
